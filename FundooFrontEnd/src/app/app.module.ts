import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { SocialLoginModule, AuthServiceConfig } from "angularx-social-login";
import { GoogleLoginProvider, FacebookLoginProvider } from "angularx-social-login";
import { ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { UserAccountsLogInComponent } from './Components/user-accounts-log-in/user-accounts-log-in.component';
import { NoteViewComponent } from './Components/note-view/note-view.component';
import { UserAddNotesComponent } from './Components/user-add-notes/user-add-notes.component';
import { HomePageComponent } from './Components/home-page/home-page.component';
import { FundooDashBoardComponent } from './Components/fundoo-dash-board/fundoo-dash-board.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FundooSideNavigationBarComponent } from './Components/fundoo-side-navigation-bar/fundoo-side-navigation-bar.component';
import { FundooTopNavigationBarComponent } from './Components/fundoo-top-navigation-bar/fundoo-top-navigation-bar.component';
import { FundooNotesContentComponent } from './Components/fundoo-notes-content/fundoo-notes-content.component';
import { FundooSignUpComponent } from './Components/fundoo-sign-up/fundoo-sign-up.component';

import { AppMaterialModule } from './Utility/AngularMaterialUtility/app.material.module';
import { DateTimePickerComponent } from './Components/Utility/date-time-picker/date-time-picker.component';
import { NotesSearchPipe } from './custom-pipe-module/NotesSearchPipeModule/notes-search.pipe';
import { FundooAdminDashboardComponent } from './Components/fundoo-admin-dashboard/fundoo-admin-dashboard.component';
import { FundooAdminLoginComponent } from './Components/fundoo-admin-login/fundoo-admin-login.component';
import { FundooAdminTopNavigationBarComponent } from './Components/FundooAdminDashboardChildComponents/fundoo-admin-top-navigation-bar/fundoo-admin-top-navigation-bar.component';
import { FundooAdminDashboardContentComponent } from './Components/FundooAdminDashboardChildComponents/fundoo-admin-dashboard-content/fundoo-admin-dashboard-content.component';


import { FundooNoteEditFormComponent } from './Components/fundoo-note-edit-form/fundoo-note-edit-form.component';
import { LabelPipePipe } from './custom-pipe-module/LabelPipe/label-pipe.pipe';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';







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

    UserAccountsLogInComponent,
    NoteViewComponent,
    UserAddNotesComponent,
    HomePageComponent,

    FundooDashBoardComponent,
    FundooSideNavigationBarComponent,
    FundooTopNavigationBarComponent,
    FundooNotesContentComponent,
    FundooSignUpComponent,
    DateTimePickerComponent,
    NotesSearchPipe,
    FundooAdminDashboardComponent,
    FundooAdminLoginComponent,
    FundooAdminTopNavigationBarComponent,
    FundooAdminDashboardContentComponent,

    FundooNoteEditFormComponent,
    LabelPipePipe,
  
    
   
    



  ],
  imports: [
    BrowserModule,
    AppRoutingModule, HttpClientModule, SocialLoginModule, FormsModule, ReactiveFormsModule, BrowserAnimationsModule, 
    AppMaterialModule ,NgbModule
    
    

  ],
  
  providers: [{
    provide: AuthServiceConfig,
    useFactory: provideConfig

  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
