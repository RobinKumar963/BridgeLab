import { Component, OnInit } from '@angular/core';
import { DataExchangeService } from 'src/app/Services/DataExchange/data-exchange.service';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.scss']
})
export class ContentComponent implements OnInit {

  constructor(private dataExchange:DataExchangeService) { }


  contentStatus: string;

  get showAddNotes() {
    return this.contentStatus === 'AddNotes';
  }

  get showViewNotes() {
    return this.contentStatus === 'ViewNotes';
  }
 
  


  ngOnInit() {
    this.dataExchange.contentStatus.subscribe(contentStatus => this.contentStatus = contentStatus)
  }

}
