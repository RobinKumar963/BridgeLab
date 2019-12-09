import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-fundoo-sign-up',
  templateUrl: './fundoo-sign-up.component.html',
  styleUrls: ['./fundoo-sign-up.component.scss']
})
export class FundooSignUpComponent implements OnInit {

  constructor() { }
  userSignupModel = new SignUP();
  ngOnInit() {
  }

}
