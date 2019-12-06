import { Component, OnInit } from '@angular/core';
import { LoginModel } from 'src/app/Modals/login-model';

@Component({
  selector: 'app-user-accounts-log-in',
  templateUrl: './user-accounts-log-in.component.html',
  styleUrls: ['./user-accounts-log-in.component.scss']
})
export class UserAccountsLogInComponent implements OnInit {

  constructor() { }
  
 
  userLoginModel = new LoginModel('','');
  get diagnostic() { return JSON.stringify(this.userLoginModel); }
  ngOnInit() {
    
  }

}
