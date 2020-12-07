import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { ActivatedRoute } from '@angular/router';
import { BuildingService } from 'src/app/core/services/building.service';
import { buildingDto } from 'src/app/model/buildingDto';
import { state } from 'src/app/model/state';


@Component({
  selector: 'app-building-view',
  templateUrl: './building-view.component.html',
  styleUrls: ['./building-view.component.css']
})
export class BuildingViewComponent implements OnInit {

  buildingData: buildingDto;
  buildingId: string;

  BuildingName: string;
  Address: string;
  Suburb: string;
  StreetNumber: string;
  Price: string;
  DisplayPrice: string;
  Description: string;
  Bedroom: string;
  Bathroom: string;
  Garage: string;
  Image: string;
  State: string;
  City: string;
  Postcode: string;

  userName: string;

  constructor(private titleService: Title,
    private buildingService: BuildingService,
    private route: ActivatedRoute) {
    this.titleService.setTitle("Palisade Miranda");
    if (state.userFirstName == null) {
      this.userName = "Account"
    }
    else {
      this.userName = state.userFirstName + " " + state.userLastName;
    }
  }

  ngOnInit(): void {
    this.buildingId = this.route.snapshot.paramMap.get("id")


    this.buildingService.buildingView(this.buildingId).subscribe(result => {
      console.log(result);
      this.buildingData = result;

      this.BuildingName = result.buildingName;
      this.Address = result.address;
      this.Suburb = result.suburb;
      this.StreetNumber = result.streetNumber;
      this.Price = result.price;
      this.DisplayPrice = result.displayPrice;
      this.Description = result.description;
      this.Bedroom = result.bedroom;
      this.Bathroom = result.bathroom;
      this.Garage = result.garage;
      this.Image = result.image;
      this.State = result.state;
      this.City = result.city;
      this.Postcode = result.postcode;
    });
  }

}
