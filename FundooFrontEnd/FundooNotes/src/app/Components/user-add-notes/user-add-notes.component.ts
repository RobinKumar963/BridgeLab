import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-user-add-notes',
  templateUrl: './user-add-notes.component.html',
  styleUrls: ['./user-add-notes.component.scss']
})
export class UserAddNotesComponent implements OnInit {

  constructor(private formBuilder: FormBuilder) { }

  
    userNotesForm = this.formBuilder.group({
    useremail: ['', Validators.required],
    noteid: ['',],
    DisplayOrder: ['', Validators.required],

    title: [''],
    description: [''],
    createddate: [''],
    modifieddata: [''],
    images: [''],
    reminder: [''],
    isarchive: ['false'],
    istrash: ['false'],
    ispin: ['false'],
    color: ['']

   
    
  
    
  });

  ngOnInit() {
  }

}
