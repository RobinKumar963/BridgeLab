import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { LoginModel } from 'src/app/Modals/login-model';
import { UserAccountService } from 'src/app/Services/UserAccount/user-account.service';
import { Router } from '@angular/router';
import { AuthService, SocialUser } from 'angularx-social-login';
import { DataExchangeService } from 'src/app/Services/DataExchange/data-exchange.service';

@Component({
  selector: 'app-user-accounts-log-in',
  templateUrl: './user-accounts-log-in.component.html',
  styleUrls: ['./user-accounts-log-in.component.scss']
})
export class UserAccountsLogInComponent implements OnInit {

  

  constructor(private dataExchange:DataExchangeService,private service:UserAccountService,private router:Router,private authService: AuthService) { }
  
 
  userLoginModel = new LoginModel('','');
  private user: SocialUser;
  private loggedIn: boolean;
  
  message:string;
  

  newMessage() {
    this.dataExchange.changeMessage(this.userLoginModel.UserEmail)
  }

  
  get diagnostic() { return JSON.stringify(this.userLoginModel); }
  token:string;



  
  FORGOT()
  {
    alert("Forgot OK");
    var userforgot=
    {
      "useremail":this.userLoginModel.UserEmail,
    }
    console.log( userforgot );
    this.service.UserForgot('Forgot',userforgot).subscribe((data:any)=>
    {
        console.log(data);
        

      });
  }

  SocialLogIN()
  {
    alert("Social Loggin in OK");
    this.authService.authState.subscribe((user) => {
      this.user = user;
    
      this.loggedIn = (user != null);
      this.service.signInWithGoogle();
      this.newMessage();
    
      this.router.navigate(['FundooDashBoard']);
    
      
    });
  }

   LogIN()
  {
    alert("Login OK");
    alert(JSON.stringify(this.userLoginModel));
    console.log( this.userLoginModel );
    this.service.UserLogIN('LogIN',this.userLoginModel).subscribe((data:any)=>
      {
        console.log(data);
        console.log(data.token);
        
        localStorage.setItem('token',data.token);
        //Redirect to dashboard
        this.newMessage();
        //this.router.navigate(['dashboard']);
        this.router.navigate(['FundooDashBoard']);
    
      });
  }
  ngOnInit() {
    this.dataExchange.currentMessage.subscribe(message => this.message = message)
  }

}
