import { Component, OnInit } from '@angular/core';
import { variable } from '@angular/compiler/src/output/output_ast';
import { UserAccountService } from 'src/app/Services/UserAccount/user-account.service';

@Component({
  selector: 'app-user-registration',
  templateUrl: './user-registration.component.html',
  styleUrls: ['./user-registration.component.scss']
})
export class UserRegistrationComponent implements OnInit {

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
