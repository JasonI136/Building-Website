import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutUsComponent } from './components/about-us/about-us.component';
import { BuildingListComponent } from './components/building-list/building-list.component';
import { BuildingViewComponent } from './components/building-view/building-view.component';
import { ContactUsComponent } from './components/contact-us/contact-us.component';
import { IndexComponent } from './components/index/index.component';
import { RegistrationComponent } from './components/registration/registration.component';
import { SignInComponent } from './components/sign-in/sign-in.component';

const routes: Routes = [
  {
    path: 'index',
    component: IndexComponent,
  },
  {
    path: 'contactUs',
    component: ContactUsComponent,
  },
  {
    path: 'aboutUs',
    component: AboutUsComponent,
  },
  {
    path: 'buildingList',
    component: BuildingListComponent,
  },
  {
    path:'building/:id',
    component: BuildingViewComponent,
  },
  {
    path:'login',
    component: SignInComponent,
  },
  {
    path:'registration',
    component: RegistrationComponent,
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
