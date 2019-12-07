import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserRegistrationComponent } from './Components/user-registration/user-registration.component';
import {UserLogINComponent} from './Components/user-log-in/user-log-in.component';
import { UserSignUpComponent } from './Components/user-sign-up/user-sign-up.component';
import { UserDashBoardComponent } from './Components/user-dash-board/user-dash-board.component';
import { UserAddNotesComponent } from './Components/user-add-notes/user-add-notes.component';
import  {NoteViewComponent} from './Components/note-view/note-view.component';
import {HomePageComponent} from './Components/home-page/home-page.component';
import{FundooDashBoardComponent} from './Components/fundoo-dash-board/fundoo-dash-board.component';
import {UserAccountsLogInComponent} from './Components/user-accounts-log-in/user-accounts-log-in.component';
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
  },
  {
    path:'UserAccountsLogIn',component:UserAccountsLogInComponent
  },
  {
    path:'ReadUserNotes',component:NoteViewComponent
  },
  {
    path:'AddUserNotes',component:UserAddNotesComponent
  },
  {
    path:'Home',component:HomePageComponent
  },
  {
    path:'FundooDashBoard',component:FundooDashBoardComponent
  }
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
