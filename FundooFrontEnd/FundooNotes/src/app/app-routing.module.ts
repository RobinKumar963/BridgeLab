import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserRegistrationComponent } from './Components/user-registration/user-registration.component';
import {UserLogINComponent} from './Components/user-log-in/user-log-in.component';
import { UserSignUpComponent } from './Components/user-sign-up/user-sign-up.component';
import { UserDashBoardComponent } from './Components/user-dash-board/user-dash-board.component';
import { UserAccountsSignUpComponent } from './Components/user-accounts-sign-up/user-accounts-sign-up.component';
import { UserAccountSignUpComponent } from './Components/user-account-sign-up/user-account-sign-up.component';
import { UserSignUpRegistrationComponent} from './Components/user-sign-up-registration/user-sign-up-registration.component';
const routes: Routes = [
  {
     path:'LogIN',component:UserLogINComponent
  },
  {
    path:'register',component:UserRegistrationComponent
  },
  {
    path:'signup',component:UserSignUpComponent
  },
  {
    path:'dashboard',component:UserDashBoardComponent

  },
  {
    path:'Registers',component:UserSignUpRegistrationComponent
  },
  {
    path:'UserAccountSignUp',component:UserAccountSignUpComponent
  },
  {
    path:'UserAccountsSignUp',component:UserAccountsSignUpComponent
  }
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
