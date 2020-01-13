import { Component, OnInit } from '@angular/core';
import { SignUp } from 'src/app/Modals/UserSignUpModel/sign-up';
import { UserAccountService } from 'src/app/Services/UserAccount/user-account.service';

@Component({
  selector: 'app-fundoo-sign-up',
  templateUrl: './fundoo-sign-up.component.html',
  styleUrls: ['./fundoo-sign-up.component.scss']
})
export class FundooSignUpComponent implements OnInit {

  constructor(private service: UserAccountService) { }
  userSignUPModel = new SignUp('', 'tobeassignedbybackend', '', '', '', 'tobeassignedlater', 'inactive');


  get diagnostic() { return JSON.stringify(this.userSignUPModel); }
  ngOnInit() {
  }

  SignUP() {
    //alert(JSON.stringify(this.userSignUPModel));

    this.service.UserSignUP('Register', this.userSignUPModel).subscribe(data => {
      console.log(data);

    });
  }


}
