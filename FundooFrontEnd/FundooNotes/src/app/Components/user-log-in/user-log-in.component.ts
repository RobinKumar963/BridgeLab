import { Component, OnInit } from '@angular/core';
import { UserAccountService } from 'src/app/Services/UserAccount/user-account.service';
import { Router, RouterModule } from '@angular/router';
import { AuthService, SocialUser } from 'angularx-social-login';
import { LoginModel } from 'src/app/Modals/login-model';

@Component({
  selector: 'app-user-log-in',
  templateUrl: './user-log-in.component.html',
  styleUrls: ['./user-log-in.component.scss']
})
export class UserLogINComponent implements OnInit {
 

  private user: SocialUser;
  private loggedIn: boolean;
  parentMessage:string;

  constructor(private service:UserAccountService,private router:Router,private authService: AuthService) { }

  token:string;
  
  //loginModel = new LoginModel('ha','haha');

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

  SocialLogIN()
  {
    alert("Social Loggin in OK");
   

    this.authService.authState.subscribe((user) => {
      this.user = user;
      this.parentMessage=user.firstName;
      this.loggedIn = (user != null);
      this.service.signInWithGoogle();
      
      this.router.navigate(['dashboard']);
      
    });

    //this.authService.authState.subscribe((user:any) => {
      //this.user = user;
      //this.loggedIn = (user != null);
      //console.log(user);
      //console.log(user.token);
      //localStorage.setItem('token',user.token);

      //Redirect to dashboard
      
    //});
  
  }

  
  LogIN()
  {
    alert("Login OK");
    
    

    var user=
    {
      "useremail":((document.getElementById("useremail") as HTMLInputElement).value),
      
      
      "Password":((document.getElementById("password") as HTMLInputElement).value)
      
    }

    var loginModel = new LoginModel(((document.getElementById("useremail") as HTMLInputElement).value),
    ((document.getElementById("password") as HTMLInputElement).value));

    alert(loginModel.UserEmail+loginModel.Password);

    console.log( user );

    this.service.UserLogIN('LogIN',user).subscribe((data:any)=>
      {
        console.log(data);
        console.log(data.token);
        
        localStorage.setItem('token',data.token);
        //Redirect to dashboard
        this.router.navigate(['dashboard']);
      });
  }


  

  ngOnInit() {


   



  }

}
