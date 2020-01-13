import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { UserAccountService } from 'src/app/Services/UserAccount/user-account.service';
import { DataExchangeService } from 'src/app/Services/DataExchange/data-exchange.service';

@Component({
  selector: 'app-fundoo-top-navigation-bar',
  templateUrl: './fundoo-top-navigation-bar.component.html',
  styleUrls: ['./fundoo-top-navigation-bar.component.scss']
})
export class FundooTopNavigationBarComponent implements OnInit {

  constructor(private service:UserAccountService,private dataExchange:DataExchangeService) { }
  @Input() currentActiveEmail: string;
  @Input() profilePicLink:string;
  @Output() searchTextEvent = new EventEmitter<string>();
  searchtext:string='';
  ngOnInit() {
  }

  isGrid: boolean = true;
  isList: boolean = false;
  selectedFile: File = null;
 
  onFileSelected(event) {
    this.selectedFile = <File>event.target.files[0];
    this.onUpload();
  }
  Search(){
    //alert("Ok");
    //alert(this.searchtext);
    this.dataExchange.changeSearchText(this.searchtext);
    this.searchTextEvent.emit('Search');
    
  }
  onDropDownClick(){
    
    var x = document.getElementById("arrow_down");
    if (x.classList.contains("up")) {
      x.classList.remove("up");

    } else {
      x.classList.add("up");
    }

    var x = document.getElementById("dropdowncontent");
    if (x.classList.contains("open")) {
      x.classList.remove("open");
      
    } else {
      x.classList.add("open");
    }

  }
  

  onUpload() {
    const uploadData = new FormData();
    uploadData.append('file', this.selectedFile, this.selectedFile.name);
    this.service.uploadImage('UploadImage',uploadData,localStorage.getItem('token')).subscribe((data: any) => {
      console.log(data);
      this.profilePicLink=data.result;
      
    });
  }
    



  

  toggleGridList() {
    var notesDisplayStyles = document.getElementsByClassName("notes");

    for (let i = 0; i < notesDisplayStyles.length; i++) {
      if (notesDisplayStyles[i].classList.contains("listview")) {
        notesDisplayStyles[i].classList.remove("listview");
      } else {
        notesDisplayStyles[i].classList.add("listview");
      }
    }

    if (this.isGrid) {
      this.isGrid = false;
      this.isList = true;
    }
    else {
      this.isGrid = true;
      this.isList = false;

    }
  }

  HideMenu() {
    //alert("Ok");
    var x = document.getElementById("sidebar");
    if (x.classList.contains("open")) {
      x.classList.remove("open");
    } else {
      x.classList.add("open");
    }
  }


}
