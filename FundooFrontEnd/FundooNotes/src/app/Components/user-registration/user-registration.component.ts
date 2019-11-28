import { Component, OnInit } from '@angular/core';
import { variable } from '@angular/compiler/src/output/output_ast';

@Component({
  selector: 'app-user-registration',
  templateUrl: './user-registration.component.html',
  styleUrls: ['./user-registration.component.scss']
})
export class UserRegistrationComponent implements OnInit {

  constructor() { }

  Display()
  {
    //document.getElementById("trialinput") as HTMLInputElement).value;
    console.log( ((document.getElementById("trialinput") as HTMLInputElement).value) );
    alert("OK");
  }
  ngOnInit() {
      
    
  }

}
