import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { DataExchangeService } from 'src/app/Services/DataExchange/data-exchange.service';
import { UseNotesService } from 'src/app/Services/UserNotes/use-notes.service';

@Component({
  selector: 'app-user-add-notes',
  templateUrl: './user-add-notes.component.html',
  styleUrls: ['./user-add-notes.component.scss']
})
export class UserAddNotesComponent implements OnInit {

  constructor(private formBuilder: FormBuilder,private dataExchange: DataExchangeService,private service:UseNotesService) { }


    currentActiveEmail: string; 
    
    
    userNotesForm = this.formBuilder.group({
    useremail: [this.currentActiveEmail],
    
    DisplayOrder: [2,'',],

    title: ['',Validators.required],
    description: ['',Validators.required],
    createddate: [''],
    modifieddata: [''],
    images: [''],
    reminder: [''],
    isarchive: ['false'],
    istrash: ['false'],
    ispin: ['false'],
    color: ['']
  
  });

  AddNotes()
  {
    alert("Adding Notes");
    
    this.userNotesForm.value.useremail=this.getEmailId();
    this.userNotesForm.value.createddate=new Date();
    this.userNotesForm.value.modifieddata=new Date();
    alert(JSON.stringify(this.userNotesForm.value));
    
    console.log( this.userNotesForm.value);
    this.service.AddNotes('AddNotes',this.userNotesForm.value,localStorage.getItem('token')).subscribe((data:any)=>
    {
      console.log(data);
      
    });
    
    
  }
  getEmailId(){
    
    this.dataExchange.currentMessage.subscribe(message => this.currentActiveEmail = message);
    return this.currentActiveEmail;
  }


  ngOnInit() {
    this.dataExchange.currentMessage.subscribe(message => this.currentActiveEmail = message);
   
   
  }

}
