import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-fundoo-top-navigation-bar',
  templateUrl: './fundoo-top-navigation-bar.component.html',
  styleUrls: ['./fundoo-top-navigation-bar.component.scss']
})
export class FundooTopNavigationBarComponent implements OnInit {

  constructor() { }
  @Input() currentActiveEmail: string;
  ngOnInit() {
  }

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

}
