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


  

  constructor() { }


  changeContentStatus(message: string) {
    this.messageSourceContentStatus.next(message)
  }

  changeMessage(message: string) {
    this.messageSource.next(message)
  }
}
