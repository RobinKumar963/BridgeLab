import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user-dash-board',
  templateUrl: './user-dash-board.component.html',
  styleUrls: ['./user-dash-board.component.scss'
]
})
export class UserDashBoardComponent implements OnInit {

  constructor() { }
  HideMenu()
  {


    



















    //alert("Ok");

        
    var x = document.getElementById("sidebar");
    if (x.style.display == "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }


 


 
  }

  ngOnInit() {
  }

}
