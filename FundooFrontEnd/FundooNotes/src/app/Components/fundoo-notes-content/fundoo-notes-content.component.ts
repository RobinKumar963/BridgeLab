import { Component, OnInit,Input } from '@angular/core';
import { UseNotesService } from 'src/app/Services/UserNotes/use-notes.service';


@Component({
  selector: 'app-fundoo-notes-content',
  templateUrl: './fundoo-notes-content.component.html',
  styleUrls: ['./fundoo-notes-content.component.scss']
})
export class FundooNotesContentComponent implements OnInit {

  constructor(private service:UseNotesService) { }

 @Input() contentStatus:string='Notes';

 
 noteFetchedAgain:any;

  
 

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

  receivenewNoteAddedEvent($event) {
    
   alert("Emitted event from addnotes recieved ");
   this.service.GetNotes('ReadNotes',localStorage.getItem('token')).subscribe((data:any)=>
   {
     console.log(data);
     this.noteFetchedAgain=data.res;
    
   });
   
   
  }


}
