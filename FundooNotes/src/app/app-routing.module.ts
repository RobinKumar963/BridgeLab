import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserRegistrationComponent } from './Components/user-registration/user-registration.component';
import {UserLogINComponent} from './Components/user-log-in/user-log-in.component';


const routes: Routes = [
  {
    /*path:'LogIN',component:UserLogINComponent*/ path:'SignUP',component:UserRegistrationComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
