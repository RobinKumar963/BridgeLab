import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { LabelServiceService } from 'src/app/Services/UserLabels/label-service.service';

@Component({
  selector: 'app-fundoo-side-navigation-bar',
  templateUrl: './fundoo-side-navigation-bar.component.html',
  styleUrls: ['./fundoo-side-navigation-bar.component.scss']
})
export class FundooSideNavigationBarComponent implements OnInit {

  constructor(private service: LabelServiceService) { }

  contentStatus: string = 'Notes';
  labels: any;


  @Output() messageEvent = new EventEmitter<string>();
  @Output() labelEvent= new EventEmitter<string>();

  ngOnInit() {
    this.service.GetLabels('ReadLabel',localStorage.getItem('token')).subscribe((data: any) => {
      console.log(data);
      this.labels = data.result;

    });
  }

  close(){
    var modal = document.getElementById("myModal");
    // Get the button that opens the modal
    var btn = document.getElementById("myBtn");

    // Get the <span> element that closes the modal
    var span = document.getElementsByClassName("close")[0];

    // When the user clicks the button, open the modal 
    
      
  

    // When the user clicks on <span> (x), close the modal
    
      modal.style.display = "none";
  }

  sm() {
    var modal = document.getElementById("myModal");

    // Get the button that opens the modal
    var btn = document.getElementById("myBtn");

    // Get the <span> element that closes the modal
    var span = document.getElementsByClassName("close")[0];

    // When the user clicks the button, open the modal 
    
      modal.style.display = "block";
  

    // When the user clicks on <span> (x), close the modal
    
      //modal.style.display = "none";
    

    // When the user clicks anywhere outside of the modal, close it
    window.onclick = function (event) {
      if (event.target == modal) {
        modal.style.display = "none";
      }
    }
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
  onLabelClick(labelName:string) {
    this.contentStatus = 'Labels';
    alert(this.contentStatus);
    this.messageEvent.emit(this.contentStatus);
    this.labelEvent.emit(labelName);
  }
  onArchiveClick() {
    this.contentStatus = 'Archive';
    alert(this.contentStatus);
    this.messageEvent.emit(this.contentStatus);
  }
  onTrashClick() {
    this.contentStatus = 'Trash';
    alert(this.contentStatus);
    this.messageEvent.emit(this.contentStatus);
  }
  
  onOtherClick() {
    this.contentStatus = 'other';
    alert(this.contentStatus);
    this.messageEvent.emit(this.contentStatus);
  }

  deleteLabel(){

  }

  editLabel(){
    
  }

}
