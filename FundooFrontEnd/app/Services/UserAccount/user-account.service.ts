import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { AuthService, GoogleLoginProvider, FacebookLoginProvider } from 'angularx-social-login';



@Injectable({
  providedIn: 'root'
})

export class UserAccountService {

  constructor(private http:HttpClient,private authService: AuthService) { }
  link = 'https://localhost:44358/api/Account/'
  
  UserSignUP(url, usersignup){ 
    return this.http.post(this.link+url,usersignup);
   }

   UserLogIN(url, userlogin){ 
    return this.http.post(this.link+url,userlogin);
   }

   UserForgot(url, userforgot){ 
    return this.http.post(this.link+url,userforgot);
   }



   signInWithGoogle(): void {
    this.authService.signIn(GoogleLoginProvider.PROVIDER_ID);
  }
 
  signInWithFB(): void {
    this.authService.signIn(FacebookLoginProvider.PROVIDER_ID);
  } 
 
  signOut(): void {
    this.authService.signOut();
  }
  
  uploadImage(url,file:FormData,token){
    var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
    return this.http.post(this.link+url,file,{ headers: headers_object });
  }

 

   
}
