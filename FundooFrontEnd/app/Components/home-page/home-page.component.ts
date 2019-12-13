import { Component, OnInit } from '@angular/core';
export type EditorType = 'SignIN' | 'LogIN';
@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent implements OnInit {

  constructor() { }


  editor: string = 'SignUP';

  get showSignUP() {
    return this.editor === 'SignUP';
  }

  get showLogIn() {
    return this.editor === 'LogIN';
  }

  toggleEditor(type:string) {
    this.editor = type;
  }
  changeEditor(){
    if(this.editor=='SignUP')
    this.editor = 'LogIN';
    else
    this.editor='SignUP';
  }

  ngOnInit() {
  }

}
