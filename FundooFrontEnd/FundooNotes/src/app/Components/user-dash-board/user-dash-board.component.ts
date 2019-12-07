import { Component, OnInit, Input } from '@angular/core';
import { UseNotesService } from 'src/app/Services/UserNotes/use-notes.service';
import { DataExchangeService } from 'src/app/Services/DataExchange/data-exchange.service';

@Component({
  selector: 'app-user-dash-board',
  templateUrl: './user-dash-board.component.html',
  styleUrls: ['./user-dash-board.component.scss'
]
})
export class UserDashBoardComponent implements OnInit {

  constructor(private service:UseNotesService,private dataExchange: DataExchangeService) { }
  message:string;
  
  GetNotes()
  {
    alert("Ok getting Notes");

    this.service.GetNotes('ReadNotes',localStorage.getItem('token')).subscribe((data:any)=>
      {
        console.log(data);
        
      });


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
  
  ngOnInit() {

    this.dataExchange.currentMessage.subscribe(message => this.message = message)

  }

}
