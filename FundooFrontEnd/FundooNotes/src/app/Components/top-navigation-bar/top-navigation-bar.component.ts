import { Component, OnInit } from '@angular/core';
import { DataExchangeService } from 'src/app/Services/DataExchange/data-exchange.service';

@Component({
  selector: 'app-top-navigation-bar',
  templateUrl: './top-navigation-bar.component.html',
  styleUrls: ['./top-navigation-bar.component.scss']
})
export class TopNavigationBarComponent implements OnInit {

  constructor(private dataExchange: DataExchangeService) { }
  message:string;

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
    this.dataExchange.currentMessage.subscribe(message => this.message = message)
  }

}
