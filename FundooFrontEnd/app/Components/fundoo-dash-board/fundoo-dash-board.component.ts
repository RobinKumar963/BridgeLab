import { Component, OnInit } from '@angular/core';
import { DataExchangeService } from 'src/app/Services/DataExchange/data-exchange.service';
@Component({
  selector: 'app-fundoo-dash-board',
  templateUrl: './fundoo-dash-board.component.html',
  styleUrls: ['./fundoo-dash-board.component.scss']
})
export class FundooDashBoardComponent implements OnInit {

  constructor(private dataExchange: DataExchangeService) { }

  currentLoggedInUsers:string;


   contentStatus:string;

  receiveMessage($event) {
    this.contentStatus = $event
  }

  ngOnInit() {
     this.dataExchange.currentMessage.subscribe(message => this.currentLoggedInUsers = message);
  }

}
