import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { state } from 'src/app/model/state';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {
  userName: string;

  constructor(private titleService: Title) {
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
  }

}
