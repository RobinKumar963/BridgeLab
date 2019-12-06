import { Component, OnInit, Injector } from '@angular/core';
import { SignUp } from 'src/app/Modals/UserSignUpModel/sign-up';
import { FormControl, FormBuilder, Validators, FormArray } from '@angular/forms';


@Component({
  selector: 'app-user-account-sign-up',
  templateUrl: './user-account-sign-up.component.html',
  styleUrls: ['./user-account-sign-up.component.scss']
})
export class UserAccountSignUpComponent implements OnInit {



 





  constructor(private fb: FormBuilder) { }


  profileForm = this.fb.group({
    firstName: ['', Validators.required],
    lastName: [''],
    address: this.fb.group({
      street: [''],
      city: [''],
      state: [''],
      zip: ['']
    }),
    aliases: this.fb.array([
      this.fb.control('')
    ])
  });
  favoriteColorControl = new FormControl('');
    //var signup = new SignUp('observingUser@gmail.com','observingUserName','observinguser','Basic');
    get()
    {
      
    }
    

    
  get aliases() {
    return this.profileForm.get('aliases') as FormArray;
  }



  addAlias() {
    this.aliases.push(this.fb.control(''));
  }

  onSubmit() {
    // TODO: Use EventEmitter with form value
    console.warn(this.profileForm.value);
  }

  


  ngOnInit() {
  }

}
