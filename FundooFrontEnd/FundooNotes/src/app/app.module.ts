import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { SocialLoginModule, AuthServiceConfig } from "angularx-social-login";
import { GoogleLoginProvider, FacebookLoginProvider } from "angularx-social-login";
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserRegistrationComponent } from './Components/user-registration/user-registration.component';
import { UserLogINComponent } from './Components/user-log-in/user-log-in.component';
import { UserSignUpComponent } from './Components/user-sign-up/user-sign-up.component';
import { FormsModule }   from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { UserDashBoardComponent } from './Components/user-dash-board/user-dash-board.component';
import { UserSignUpRegistrationComponent } from './Components/user-sign-up-registration/user-sign-up-registration.component';
import { UserAccountSignUpComponent } from './Components/user-account-sign-up/user-account-sign-up.component';
import { UserAccountsSignUpComponent } from './Components/user-accounts-sign-up/user-accounts-sign-up.component';


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
    UserSignUpRegistrationComponent,
    UserAccountSignUpComponent,
    UserAccountsSignUpComponent
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,HttpClientModule,SocialLoginModule, FormsModule,ReactiveFormsModule
  ],
  providers: [{
    provide: AuthServiceConfig,
    useFactory: provideConfig

  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
