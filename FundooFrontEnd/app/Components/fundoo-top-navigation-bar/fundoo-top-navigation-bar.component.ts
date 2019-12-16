import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-fundoo-top-navigation-bar',
  templateUrl: './fundoo-top-navigation-bar.component.html',
  styleUrls: ['./fundoo-top-navigation-bar.component.scss']
})
export class FundooTopNavigationBarComponent implements OnInit {

  constructor() { }
  @Input() currentActiveEmail: string;
  ngOnInit() {
  }
  isGrid:boolean=true;
  isList:boolean=false;

  
  toggleGridList(){
    var notesDisplayStyles = document.getElementsByClassName("notes");
    
    for (let i = 0; i < notesDisplayStyles.length; i++) {
      if (notesDisplayStyles[i].classList.contains("listview")) {
        notesDisplayStyles[i].classList.remove("listview");
      } else {
        notesDisplayStyles[i].classList.add("listview");
      }
    } 

    if(this.isGrid)
    {
      this.isGrid=false;
      this.isList=true;
    }
    else
    {
      this.isGrid=true;
      this.isList=false;

    }
  }
  HideMenu()
  {
    //alert("Ok");
    var x = document.getElementById("sidebar");
    if (x.classList.contains("open")) {
    x.classList.remove("open");
    } else {
      x.classList.add("open");
    }
  }

}
