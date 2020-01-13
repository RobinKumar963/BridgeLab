import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LabelServiceService {
  link = 'https://localhost:44358/api/Label/'
  constructor(private http:HttpClient) { }
  GetLabels(url, token){ 

    var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
    return this.http.get(this.link+url, { headers: headers_object });
  
  }
  AddLabels(url,labelModel,token){
    var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
    return this.http.post(this.link+url,labelModel,{ headers: headers_object });
  }
  patchUpdateLabels(url,labelUpdateModel,token){
    var headers_object = new HttpHeaders().set("Authorization", "Bearer " + token);
    return this.http.patch(this.link+url,labelUpdateModel,{headers:headers_object});
  }
  deleteLabel(url,id,token){
    var headers_object = new HttpHeaders().set("Authorization", "Bearer" + token);
    return this.http.delete(this.link+url,{headers:headers_object});

}
}