import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { IndexComponent } from './components/index/index.component';
import { AddBuildingComponent } from './components/add-building/add-building.component';


const routes: Routes = [
  {
    path:'index',
    component: IndexComponent,
  },
  {
    path:'addBuilding',
    component: AddBuildingComponent,
  },
  {
    path:'',
    redirectTo:'/index',
    pathMatch:'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
