import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataExchangeService {


  
  private messageSource = new BehaviorSubject('Not LoggedIn');
  currentMessage = this.messageSource.asObservable();

  private messageSourceContentStatus = new BehaviorSubject('Not LoggedIn.....No Contents');
  contentStatus = this.messageSourceContentStatus.asObservable();

  private profileImageLinkSource = new BehaviorSubject('U');
  profileImageLink = this.profileImageLinkSource.asObservable();

  private searchTextSource = new BehaviorSubject('');
  searchTexts = this.searchTextSource.asObservable();

  constructor() { }


  changeContentStatus(message: string) {
    this.messageSourceContentStatus.next(message);
  }
  setProfileImage(imageLink:string){
    this.profileImageLinkSource.next(imageLink);
  }

  changeMessage(message: string) {
    this.messageSource.next(message);
  }

  changeSearchText(searchtext:string){
    this.searchTextSource.next(searchtext);
  }
}
