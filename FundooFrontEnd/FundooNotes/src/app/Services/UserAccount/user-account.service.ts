import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';



@Injectable({
  providedIn: 'root'
})

export class UserAccountService {

  constructor(private http:HttpClient) { }
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
 

   
}
