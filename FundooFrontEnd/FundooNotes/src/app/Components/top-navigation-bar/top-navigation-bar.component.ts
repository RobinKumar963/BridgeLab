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

  ngOnInit() {
    this.dataExchange.currentMessage.subscribe(message => this.message = message)
  }

}
