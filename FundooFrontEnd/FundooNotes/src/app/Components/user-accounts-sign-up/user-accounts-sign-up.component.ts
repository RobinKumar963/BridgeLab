import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-user-accounts-sign-up',
  templateUrl: './user-accounts-sign-up.component.html',
  styleUrls: ['./user-accounts-sign-up.component.scss']
})
export class UserAccountsSignUpComponent implements OnInit {

  constructor(private formBuilder: FormBuilder) { }


  profileForm = this.formBuilder.group({
    UserName: ['', Validators.required],
    UserEmail: ['', Validators.required],
    Password:['',Validators.required],
    ConfirmPassword:['',Validators.required],
    
    CardType: this.formBuilder.group({
      cardtype: ['']
    

    }),
    
  });
  
  
    get()
    {
      
    }
    

    
  



 

  onSubmit() {
    // TODO: Use EventEmitter with form value
    console.warn(this.profileForm.value);
    




  }

  ngOnInit() {
  }

}
