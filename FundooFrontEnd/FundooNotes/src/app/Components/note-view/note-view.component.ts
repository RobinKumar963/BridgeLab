import { Component, OnInit, Input, SimpleChanges } from '@angular/core';
import { UseNotesService } from 'src/app/Services/UserNotes/use-notes.service';

@Component({
  selector: 'app-note-view',
  templateUrl: './note-view.component.html',
  styleUrls: ['./note-view.component.scss']
})
export class NoteViewComponent implements OnInit {

  constructor(private service:UseNotesService) { }
   userFetchedNotes:any;
   @Input() noteReloadStatus: string;
  
  ngOnInit() {

    this.GetNotes();
  }

  ngOnChanges(changes: SimpleChanges) {
    this.GetNotes();
    alert(this.noteReloadStatus);
    this.noteReloadStatus='false';
  }


  


  GetNotes()
  {
    alert("Ok getting Notes");

    this.service.GetNotes('ReadNotes',localStorage.getItem('token')).subscribe((data:any)=>
      {
        console.log(data);
        this.userFetchedNotes=data.res;
       
      });



  }

}
