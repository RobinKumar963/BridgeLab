import { Component, OnInit } from '@angular/core';
import { UserAccountService } from 'src/app/Services/UserAccount/user-account.service';

@Component({
  selector: 'app-user-sign-up',
  templateUrl: './user-sign-up.component.html',
  styleUrls: ['./user-sign-up.component.scss']
})
export class UserSignUpComponent implements OnInit {

  constructor(private service:UserAccountService) { }



  Validate()
  {
    window.addEventListener('load', function() {
      // Fetch all the forms we want to apply custom Bootstrap validation styles to
      var forms = document.getElementsByClassName('needs-validation');
      // Loop over them and prevent submission
      var validation = Array.prototype.filter.call(forms, function(form) {
      form.addEventListener('submit', function(event) {
      if (form.checkValidity() === false) {
      event.preventDefault();
      event.stopPropagation();
      }
      form.classList.add('was-validated');
      }, false);
      });
      }, false);
      
      var user=
      {
        "useremail":((document.getElementById("validationCustom01") as HTMLInputElement).value),
        "userid":"null",
        "UserName":((document.getElementById("validationCustomUsername") as HTMLInputElement).value),
        "Password":((document.getElementById("validationCustom02") as HTMLInputElement).value),
        "CardType":((document.getElementById("validationCustom03") as HTMLInputElement).value)
      }
      console.log( user );
      
      this.service.UserSignUP('Register',user).subscribe(data=>
        {
          console.log(data);
          
        });
      
  }


  helloWorld() {
    return 'Hello world!';
  }


















  Add()
  {
    alert("OK");

    var user=
    {
      "useremail":((document.getElementById("useremail") as HTMLInputElement).value),
      "userid":"null",
      "UserName":((document.getElementById("username") as HTMLInputElement).value),
      "Password":((document.getElementById("password") as HTMLInputElement).value),
      "CardType":((document.getElementById("cardtype") as HTMLInputElement).value)
    }

    console.log( user );

    this.service.UserSignUP('Register',user).subscribe(data=>
      {
        console.log(data);
      });
  }
  

  ngOnInit() {

  }

}
