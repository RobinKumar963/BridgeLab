import { Component, OnInit, Input, SimpleChanges } from '@angular/core';
import { UseNotesService } from 'src/app/Services/UserNotes/use-notes.service';

@Component({
  selector: 'app-note-view',
  templateUrl: './note-view.component.html',
  styleUrls: ['./note-view.component.scss']
})
export class NoteViewComponent implements OnInit {

  constructor(private service: UseNotesService) { }
  userFetchedNotes: any;
  @Input() noteViewMode: string;
  @Input() noteFetchedAgain: boolean;
  pinNotes: boolean = true;
  unPinNotes: boolean = true;
  reminderNotes: boolean = false;
  labelNotes: boolean = false;
  archiveNotes: boolean = false;
  trashNotes: boolean = false;


  ngOnInit() {

    this.GetNotes();
  }

  ngOnChanges(changes: SimpleChanges) {
    if (this.noteFetchedAgain == true) {
      this.GetNotes();
      this.noteFetchedAgain = false;
    }

    if (this.noteViewMode == 'Notes') {
      this.pinNotes=true;
      this.unPinNotes=true;
      this.reminderNotes=false;
      this.labelNotes=false;
      this.archiveNotes=false;
      this.trashNotes=false;
    }

    if (this.noteViewMode == 'Reminders') {
      this.pinNotes=false;
      this.unPinNotes=false;
      this.reminderNotes=true;
      this.labelNotes=false;
      this.archiveNotes=false;
      this.trashNotes=false;

    }
    if (this.noteViewMode == 'Labels') {
      this.pinNotes=false;
      this.unPinNotes=false;
      this.reminderNotes=false;
      this.labelNotes=true;
      this.archiveNotes=false;
      this.trashNotes=false;

    }
    if (this.noteViewMode == 'Archive') {
      this.pinNotes=false;
      this.unPinNotes=false;
      this.reminderNotes=false;
      this.labelNotes=false;
      this.archiveNotes=true;
      this.trashNotes=false;
    }
    if (this.noteViewMode == 'Trash') {
      this.pinNotes=false;
      this.unPinNotes=false;
      this.reminderNotes=false;
      this.labelNotes=false;
      this.archiveNotes=false;
      this.trashNotes=true;

    }
  }





  GetNotes() {
    alert("Ok getting Notes");

    this.service.GetNotes('ReadNotes', localStorage.getItem('token')).subscribe((data: any) => {
      console.log(data);
      this.userFetchedNotes = data.res;

    });



  }

}
