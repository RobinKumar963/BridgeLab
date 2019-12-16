import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { LabelServiceService } from 'src/app/Services/UserLabels/label-service.service';

@Component({
  selector: 'app-fundoo-side-navigation-bar',
  templateUrl: './fundoo-side-navigation-bar.component.html',
  styleUrls: ['./fundoo-side-navigation-bar.component.scss']
})
export class FundooSideNavigationBarComponent implements OnInit {

  constructor(private service:LabelServiceService) { }

  contentStatus: string = 'Notes';
  labels:any;


  @Output() messageEvent = new EventEmitter<string>();

  ngOnInit() {
    this.service.GetLabels('ReadLabel', localStorage.getItem('token')).subscribe((data: any) => {
      console.log(data);
      this.labels = data.result;
      
    });
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
