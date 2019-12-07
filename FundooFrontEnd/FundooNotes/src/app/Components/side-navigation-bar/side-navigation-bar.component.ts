import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { UseNotesService } from 'src/app/Services/UserNotes/use-notes.service';
import { DataExchangeService } from 'src/app/Services/DataExchange/data-exchange.service';

@Component({
  selector: 'app-side-navigation-bar',
  templateUrl: './side-navigation-bar.component.html',
  styleUrls: ['./side-navigation-bar.component.scss']
})
export class SideNavigationBarComponent implements OnInit {

  constructor(private service:UseNotesService,private dataExchange:DataExchangeService) { }

  contentStatus:string='';
 

  ngOnInit() {

    this.dataExchange.contentStatus.subscribe(contentStatus => this.contentStatus = this.contentStatus)
  }

  changeContentStatus(status:string)
  {
    
    this.dataExchange.changeContentStatus(status);
    
    

  }
 


  GetNotes()
  {
    alert("Ok getting Notes");

    this.service.GetNotes('ReadNotes',localStorage.getItem('token')).subscribe((data:any)=>
      {
        console.log(data);
        
      });


  }






 
}
