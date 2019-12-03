import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user-sign-up-registration',
  templateUrl: './user-sign-up-registration.component.html',
  styleUrls: ['./user-sign-up-registration.component.scss']
})
export class UserSignUpRegistrationComponent implements OnInit {

  constructor() { }

  
  

  trial()
  {
    console.log("trial called!");
  }

  ngOnInit() {
    alert("Ok started");
    console.log("trial called!");
    var forms=document.getElementsByClassName('trialform');
    
    
    
  }

}
