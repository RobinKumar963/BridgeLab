import { Component, OnInit } from '@angular/core';
import { UserAccountService } from 'src/app/Services/UserAccount/user-account.service';

@Component({
  selector: 'app-user-sign-up',
  templateUrl: './user-sign-up.component.html',
  styleUrls: ['./user-sign-up.component.scss']
})
export class UserSignUpComponent implements OnInit {

  constructor(private service:UserAccountService) { }

  Add()
  {
    alert("OK");

    var user=
    {
      "useremail":((document.getElementById("useremail") as HTMLInputElement).value),
      "userid":"null",
      "UserName":((document.getElementById("username") as HTMLInputElement).value),
      "Password":((document.getElementById("password") as HTMLInputElement).value),
      "CardType":((document.getElementById("cardtype") as HTMLInputElement).value)
    }

    console.log( user );

    this.service.UserSignUP('Register',user).subscribe(data=>
      {
        console.log(data);
      });
  }
  

  ngOnInit() {

  }

}
