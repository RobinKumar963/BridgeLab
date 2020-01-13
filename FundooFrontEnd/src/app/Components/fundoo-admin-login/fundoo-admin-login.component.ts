import { Component, OnInit } from '@angular/core';
import { AdminLogin } from 'src/app/Modals/AdminModel/admin-login';
import { AdminAccountService } from 'src/app/Services/AdminAccount/admin-account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-fundoo-admin-login',
  templateUrl: './fundoo-admin-login.component.html',
  styleUrls: ['./fundoo-admin-login.component.scss']
})
export class FundooAdminLoginComponent implements OnInit {

  constructor(private service:AdminAccountService,private router: Router) { }
  
  adminLoginModel = new AdminLogin('','');
  ngOnInit() {
  }
  
  LogIN() {
    alert("Login OK");
    alert(JSON.stringify(this.adminLoginModel));
    console.log(this.adminLoginModel);
    this.service.AdminLogIN('LogIN', this.adminLoginModel).subscribe((data: any) => {
      console.log(data);
      console.log(data.token);

      localStorage.setItem('token', data.token);
      //Redirect to dashboard
      
      
      //this.router.navigate(['dashboard']);
      this.router.navigate(['FundooAdminDashBoard']);

    });
  }
  onSubmit() {

  }

  FORGOT(){
    
  }
}
