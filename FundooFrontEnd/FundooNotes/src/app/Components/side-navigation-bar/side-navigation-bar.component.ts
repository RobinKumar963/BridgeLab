import { Component, OnInit } from '@angular/core';
import { UseNotesService } from 'src/app/Services/UserNotes/use-notes.service';

@Component({
  selector: 'app-side-navigation-bar',
  templateUrl: './side-navigation-bar.component.html',
  styleUrls: ['./side-navigation-bar.component.scss']
})
export class SideNavigationBarComponent implements OnInit {

  constructor(private service:UseNotesService) { }

  ngOnInit() {
  }


  GetNotes()
  {
    alert("Ok getting Notes");

    this.service.GetNotes('ReadNotes',localStorage.getItem('token')).subscribe((data:any)=>
      {
        console.log(data);
        
      });


  }






  HideMenu()
  {
    //alert("Ok");
    var x = document.getElementById("sidebar");
    if (x.style.display == "none") {
    x.style.display = "block";
    } else {
    x.style.display = "none";
    }
  }
}
