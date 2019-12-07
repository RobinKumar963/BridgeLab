import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataExchangeService {


  private messageSource = new BehaviorSubject('default message');
  currentMessage = this.messageSource.asObservable();

  private messageSourceContentStatus = new BehaviorSubject('default message');
  contentStatus = this.messageSourceContentStatus.asObservable();

  constructor() { }


  changeContentStatus(message: string) {
    this.messageSourceContentStatus.next(message)
  }

  changeMessage(message: string) {
    this.messageSource.next(message)
  }
}
