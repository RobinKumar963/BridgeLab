import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-fundoo-side-navigation-bar',
  templateUrl: './fundoo-side-navigation-bar.component.html',
  styleUrls: ['./fundoo-side-navigation-bar.component.scss']
})
export class FundooSideNavigationBarComponent implements OnInit {

  constructor() { }

  contentStatus: string = 'Notes';



  @Output() messageEvent = new EventEmitter<string>();

  ngOnInit() {
  }

  onNotesClick() {
    this.contentStatus = 'Notes';
    alert(this.contentStatus);
    this.messageEvent.emit(this.contentStatus);
  }

  onReminderClick() {
    this.contentStatus = 'Reminder';
    alert(this.contentStatus);
    this.messageEvent.emit(this.contentStatus);
  }
  onLabelClick() {
    this.contentStatus = 'Labels';
    alert(this.contentStatus);
    this.messageEvent.emit(this.contentStatus);
  }
  onArchiveClick(){
    this.contentStatus='Archive';
    alert(this.contentStatus);
    this.messageEvent.emit(this.contentStatus);
  }
  onTrashClick(){
    this.contentStatus='Trash';
    alert(this.contentStatus);
    this.messageEvent.emit(this.contentStatus);
  }




  onOtherClick() {
    this.contentStatus = 'other';
    alert(this.contentStatus);
    this.messageEvent.emit(this.contentStatus);
  }



}
