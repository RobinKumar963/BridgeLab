import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-fundoo-note-edit-form',
  templateUrl: './fundoo-note-edit-form.component.html',
  styleUrls: ['./fundoo-note-edit-form.component.scss']
})
export class FundooNoteEditFormComponent implements OnInit {

  constructor(private formBuilder: FormBuilder) { }
  @Input() noteEdit: any;

  
  
  ngOnInit() {

    
  }


}
