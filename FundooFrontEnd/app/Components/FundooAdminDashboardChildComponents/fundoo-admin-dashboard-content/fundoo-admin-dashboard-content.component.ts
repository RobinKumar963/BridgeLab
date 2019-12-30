import { Component, OnInit } from '@angular/core';
import { AdminAccountService } from 'src/app/Services/AdminAccount/admin-account.service';

@Component({
  selector: 'app-fundoo-admin-dashboard-content',
  templateUrl: './fundoo-admin-dashboard-content.component.html',
  styleUrls: ['./fundoo-admin-dashboard-content.component.scss']
})
export class FundooAdminDashboardContentComponent implements OnInit {

  constructor(private service: AdminAccountService) { }
  userstatistics: any;
  userdetails: any;
  isUserStatistics: boolean;
  isUserDetails: boolean;


    source: any =
    {
      localdata: this.userdetails,
      datatype: "array",
      datafields:
        [
          { name: 'username', type: 'string' },
          { name: 'useremail', type: 'string' },
          { name: 'service', type: 'string' },
          { name: 'notes', type: 'number' },
          { name: 'status', type: 'string' },
          
        ],
      sortcolumn: 'username',
      sortdirection: 'asc'
    };

    dataAdapter: any = new jqx.dataAdapter(this.source);


  ngOnInit() {
    //this.userStatistics();
  }
  toggleDisplay() {
    var userDetails = document.getElementsByClassName("userdetails")[0];
    var userStatistics = document.getElementsByClassName("userstatistics")[0];
    if (userStatistics.classList.contains("active")) {
      userStatistics.classList.remove("active");
      userDetails.classList.add("active");

    } else {
      userStatistics.classList.add("active");
      userDetails.classList.remove("active");
    }
  }

  userStatistics() {
    this.isUserStatistics = true;
    this.isUserDetails = false;
    this.service.GetUserStatistics('GetUserStatistics', localStorage.getItem('token')).subscribe((data: any) => {
      console.log(data);
      this.userstatistics = data.result;

    });
  }

  userDetails() {
    this.isUserStatistics = false;
    this.isUserDetails = true;
    this.service.GetUserDetails('GetUserDetails', localStorage.getItem('token')).subscribe((data: any) => {
      console.log(data);
      this.userdetails = data.result;

    });

  }
  
}
