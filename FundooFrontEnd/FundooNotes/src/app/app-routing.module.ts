import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserRegistrationComponent } from './Components/user-registration/user-registration.component';
import {UserLogINComponent} from './Components/user-log-in/user-log-in.component';
import { UserSignUpComponent } from './Components/user-sign-up/user-sign-up.component';

const routes: Routes = [
  {
     path:'LogIN',component:UserLogINComponent
  },
  {
    path:'register',component:UserRegistrationComponent
  },
  {
    path:'signup',component:UserSignUpComponent
  }

  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
