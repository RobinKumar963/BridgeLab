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
    UserName: ['Enter UserName', Validators.required],
    UserEmail: ['Enter UserEmail', Validators.required],
    Password:['Enter Password',Validators.required],
    ConfirmPassword:['Enter Password Again To Enter',Validators.required],
    
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
