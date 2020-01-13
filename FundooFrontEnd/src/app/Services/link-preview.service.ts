import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LinkPreviewService {
  
  constructor(private http:HttpClient) { }
  link = 'https://api.linkpreview.net/'

  GetLinkPreview(keys:any,site:any){
    return this.http.get('site', {
      params: {
        key:keys,
        q:site
      },
      //observe: 'response'
    })
    //.then(response => {
      //console.log(response);
    //});
    //.catch(console.log);
  }
  
}
