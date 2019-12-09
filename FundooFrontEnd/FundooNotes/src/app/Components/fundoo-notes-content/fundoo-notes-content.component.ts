import { Component, OnInit,Input } from '@angular/core';

@Component({
  selector: 'app-fundoo-notes-content',
  templateUrl: './fundoo-notes-content.component.html',
  styleUrls: ['./fundoo-notes-content.component.scss']
})
export class FundooNotesContentComponent implements OnInit {

  constructor() { }

 @Input() contentStatus:string='Notes';

  ngOnInit() {
  }

  get showAddNotes(){

    if(this.contentStatus=='Notes')
    {
      return this.contentStatus==='Notes';
    }
    else if(this.contentStatus == 'Reminder')
    {
      return this.contentStatus==='Reminder'

    }
    else
    {
      return false;
    }
    
    
      

    
    



  }
  get showViewNotes(){
      return true;
  }



}
