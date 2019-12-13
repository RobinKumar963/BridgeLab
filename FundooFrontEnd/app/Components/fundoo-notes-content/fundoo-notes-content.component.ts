import { Component, OnInit, Input, SimpleChanges } from '@angular/core';



@Component({
  selector: 'app-fundoo-notes-content',
  templateUrl: './fundoo-notes-content.component.html',
  styleUrls: ['./fundoo-notes-content.component.scss']
})
export class FundooNotesContentComponent implements OnInit {

  constructor() { }

  @Input() contentStatus: string = 'Notes';


  noteFetchAgain: boolean;




  ngOnInit() {
  }
  ngOnChanges(changes: SimpleChanges) {

    this.noteFetchAgain = false;


  }
  get showAddNotes() {

    if (this.contentStatus == 'Notes') {

      return this.contentStatus === 'Notes';
    }
    else if (this.contentStatus == 'Reminder') {

      return this.contentStatus === 'Reminder'

    }
    else {
      return false;
    }

  }
  get showViewNotes() {
    return true;
  }

  receivenewNoteAddedEvent($event) {

    //alert("Emitted event from addnotes recieved ");


    this.noteFetchAgain = $event;




  }

  receiveAcknowledgment($event)
  {
    //alert("Acknownledgment Recieved");
    if($event)
    this.noteFetchAgain=false;
  }

}
