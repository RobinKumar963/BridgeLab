import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {MatCardModule} from '@angular/material/card';
import {MatButtonModule} from '@angular/material/button';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserRegistrationComponent } from './Components/user-registration/user-registration.component';
import { UserLogINComponent } from './Components/user-log-in/user-log-in.component';

@NgModule({
  declarations: [
    AppComponent,
    UserRegistrationComponent,
    UserLogINComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,MatCardModule,MatButtonModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
