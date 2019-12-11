import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { UserAddNotesComponent } from './Components/user-add-notes/user-add-notes.component';
import  {NoteViewComponent} from './Components/note-view/note-view.component';
import {HomePageComponent} from './Components/home-page/home-page.component';
import{FundooDashBoardComponent} from './Components/fundoo-dash-board/fundoo-dash-board.component';
import {UserAccountsLogInComponent} from './Components/user-accounts-log-in/user-accounts-log-in.component';

const routes: Routes = [
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
