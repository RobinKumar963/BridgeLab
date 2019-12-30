import { Component, OnInit, Input, SimpleChanges, Output, EventEmitter, ChangeDetectorRef } from '@angular/core';
import { UseNotesService } from 'src/app/Services/UserNotes/use-notes.service';
import { CdkDragDrop, moveItemInArray, transferArrayItem } from '@angular/cdk/drag-drop';
import { DataExchangeService } from 'src/app/Services/DataExchange/data-exchange.service';
import { LinkPreviewService } from 'src/app/Services/link-preview.service';

@Component({
  selector: 'app-note-view',
  templateUrl: './note-view.component.html',
  styleUrls: ['./note-view.component.scss']
})
export class NoteViewComponent implements OnInit {

  BgColor: any = '#202124';
  get bgColor() { return '#202124'; }
  constructor(private service: UseNotesService,private linkPreviewService:LinkPreviewService, private dataExchange: DataExchangeService) { }
  userFetchedNotes: any;
  @Input() noteViewMode: string;
  @Input() noteFetchedAgain: boolean;
  @Output() acknowledgmentRecieved = new EventEmitter<boolean>();
  pinNotes: boolean = true;
  unPinNotes: boolean = true;
  reminderNotes: boolean = false;
  labelNotes: boolean = false;
  archiveNotes: boolean = false;
  trashNotes: boolean = false;
  searchNotes: boolean = false;
  searchText: string;
  //previousSearchText:string;






  ngOnInit() {

    this.GetNotes();
    //this.dataExchange.searchTexts.subscribe(message => this.searchText = message);


  }

  Drop(event: CdkDragDrop<string[]>) {
    if (event.isPointerOverContainer)
      alert("Ok");
    else
      alert("Not Ok");

    alert(" Dropped from " + event.previousIndex + " to " + event.currentIndex + "Thus,Dropped Item:");
    //console.log(event.item);
    console.log('dropped Event', `> dropped '${event.item.data}' into '${event.container.id}'`);

    moveItemInArray(this.userFetchedNotes, event.previousIndex, event.currentIndex);

  }
  onColorClick() {
    var x = document.getElementById("colorpick");
    if (x.classList.contains("open")) {
      x.classList.remove("open");
    } else {
      x.classList.add("open");
    }

  }
  ngOnChanges(changes: SimpleChanges) {
    //this.dataExchange.searchTexts.subscribe(message => this.searchText = message);
    //alert(this.searchText);

    if (this.noteFetchedAgain == true) {
      alert(JSON.stringify(changes));
      this.GetNotes();
      this.noteFetchedAgain = false;
      this.acknowledgmentRecieved.emit(true);
    }

    if (this.noteViewMode == 'Notes') {
      this.pinNotes = true;
      this.unPinNotes = true;
      this.reminderNotes = false;
      this.labelNotes = false;
      this.archiveNotes = false;
      this.trashNotes = false;
      this.searchNotes = false;
    }

    if (this.noteViewMode == 'Reminder') {
      this.pinNotes = false;
      this.unPinNotes = false;
      this.reminderNotes = true;
      this.labelNotes = false;
      this.archiveNotes = false;
      this.trashNotes = false;
      this.searchNotes = false;
    }
    if (this.noteViewMode == 'Labels') {
      this.pinNotes = false;
      this.unPinNotes = false;
      this.reminderNotes = false;
      this.labelNotes = true;
      this.archiveNotes = false;
      this.trashNotes = false;
      this.searchNotes = false;
    }
    if (this.noteViewMode == 'Archive') {
      this.pinNotes = false;
      this.unPinNotes = false;
      this.reminderNotes = false;
      this.labelNotes = false;
      this.archiveNotes = true;
      this.trashNotes = false;
      this.searchNotes = false;
    }
    if (this.noteViewMode == 'Trash') {
      this.pinNotes = false;
      this.unPinNotes = false;
      this.reminderNotes = false;
      this.labelNotes = false;
      this.archiveNotes = false;
      this.trashNotes = true;
      this.searchNotes = false;

    }
    if (this.noteViewMode == 'Search') {
      this.dataExchange.searchTexts.subscribe(message => this.searchText = message);
      //alert(this.searchText);
      this.pinNotes = false;
      this.unPinNotes = false;
      this.reminderNotes = false;
      this.labelNotes = false;
      this.archiveNotes = false;
      this.trashNotes = false;
      this.searchNotes = true;
    }
  }


  updateNoteModel(note: any, NewValue: string, NoteAttributeName: string) {
    for (let i = 0; i < this.userFetchedNotes.length; i++) {

      if (this.userFetchedNotes[i].noteid == note.noteid) {
        this.userFetchedNotes[i].ispin = JSON.parse(NewValue);
      }
    }
  }

  GetLinkPreview(key:any,site:any){
    this.linkPreviewService.GetLinkPreview(key,site).subscribe((data: any) => {
      console.log(data);
      

    });
    //console.log(linkPreview);

  }

  GetNotes() {
    //alert("Ok getting Notes");

    this.service.GetNotes('ReadNotes', localStorage.getItem('token')).subscribe((data: any) => {
      console.log(data);
      this.userFetchedNotes = data.res;

    });



  }

  isUrl(notesDescription: string) {

    var regexp = /(ftp|http|https):\/\/(\w+:{0,1}\w*@)?(\S+)(:[0-9]+)?(\/|\/([\w#!:.?+=&%@!\-\/]))?/;
   
    
    return regexp.test(notesDescription);
  }

  patchNoteUpdate(note: any, NewValue: string, NoteAttributeName: string) {
    alert("Patching");

    var obj = {
      "id": note.noteid,
      "newvalue": NewValue,
      "noteattributename": NoteAttributeName
    }
    alert(JSON.stringify(obj));
    this.service.patchUpdateNotes('UpdateNotes', obj, localStorage.getItem('token')).subscribe((data: any) => {
      console.log(data);
      //this.GetNotes();
      this.updateNoteModel(note, NewValue, NoteAttributeName);

    });

  }

  thunbailFinder(){
    
  }






}
