import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { SocialLoginModule, AuthServiceConfig } from "angularx-social-login";
import { GoogleLoginProvider, FacebookLoginProvider } from "angularx-social-login";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserRegistrationComponent } from './Components/user-registration/user-registration.component';
import { UserLogINComponent } from './Components/user-log-in/user-log-in.component';
import { UserSignUpComponent } from './Components/user-sign-up/user-sign-up.component';

import { HttpClientModule } from '@angular/common/http';
import { UserDashBoardComponent } from './Components/user-dash-board/user-dash-board.component';
import { UserSignUpRegistrationComponent } from './Components/user-sign-up-registration/user-sign-up-registration.component';


let config = new AuthServiceConfig([
  {
    id: GoogleLoginProvider.PROVIDER_ID,
    provider: new GoogleLoginProvider("342134729958-t8r4v65kv3kcte5infaboi3lrvfrics4.apps.googleusercontent.com")
  },
  {
    id: FacebookLoginProvider.PROVIDER_ID,
    provider: new FacebookLoginProvider("Facebook-App-Id")
  }
]);
 
export function provideConfig() {
  return config;
}

@NgModule({
  declarations: [
    AppComponent,
    UserRegistrationComponent,
    UserLogINComponent,
    UserSignUpComponent,
    UserDashBoardComponent,
    UserSignUpRegistrationComponent
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,HttpClientModule,SocialLoginModule
  ],
  providers: [{
    provide: AuthServiceConfig,
    useFactory: provideConfig

  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
