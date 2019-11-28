import { Component, OnInit } from '@angular/core';
import { UserAccountService } from 'src/app/Services/UserAccount/user-account.service';

@Component({
  selector: 'app-user-log-in',
  templateUrl: './user-log-in.component.html',
  styleUrls: ['./user-log-in.component.scss']
})
export class UserLogINComponent implements OnInit {

  constructor(private service:UserAccountService) { }

  token:string;
  

  FORGOT()
  {
    alert("Forgot OK");

    var userforgot=
    {
      "useremail":((document.getElementById("useremail") as HTMLInputElement).value),
    }

    console.log( userforgot );

    this.service.UserForgot('Forgot',userforgot).subscribe((data:any)=>
      {
        console.log(data);
      });
  }

  
  LogIN()
  {
    alert("OK");

    var user=
    {
      "useremail":((document.getElementById("useremail") as HTMLInputElement).value),
      
      
      "Password":((document.getElementById("password") as HTMLInputElement).value)
      
    }

    console.log( user );

    this.service.UserLogIN('LogIN',user).subscribe((data:any)=>
      {
        console.log(data);
        console.log(data.token);
        localStorage.setItem('token',data.token);
      });
  }


  

  ngOnInit() {
    
  }

}
