import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { promise } from 'protractor';

@Injectable({
  providedIn: 'root'
})
export class AdminAccountService {

  constructor(private http:HttpClient) { }
  link = 'https://localhost:44358/api/Admin/'
  AdminLogIN(url, adminlogin){ 
  return this.http.post(this.link+url,adminlogin);
 }  

 GetUserStatistics(url,token){
    var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
    return this.http.get(this.link+url, { headers: headers_object });
 }
 GetUserDetails(url,token){
  var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
  return this.http.get(this.link+url, { headers: headers_object });
}

}

