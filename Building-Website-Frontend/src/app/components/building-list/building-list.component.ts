import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { BuildingService } from 'src/app/core/services/building.service';
import { buildingDto } from 'src/app/model/buildingDto';
import { state } from 'src/app/model/state';

@Component({
  selector: 'app-building-list',
  templateUrl: './building-list.component.html',
  styleUrls: ['./building-list.component.css']
})
export class BuildingListComponent implements OnInit {

  buildingData: buildingDto[];
  userName: string;
  
  
  constructor(private titleService: Title,
              private buildingService: BuildingService) {
    this.titleService.setTitle("Palisade Miranda");
    if(state.userFirstName == null)
    {
      this.userName = "Account"
    }
    else
    {
      this.userName = state.userFirstName + " " + state.userLastName;
    }
   }

  ngOnInit(): void {
    this.buildingService.buildingList().subscribe(data => {
      console.log(data);
      this.buildingData = data;
      //buildings = items.map(this._buildings.bind(this));

    })
  }

  // goBuildings(){
  //   this.router.navigate(['/building'],{ queryParams: {id: 'test'}});
  // }

}
