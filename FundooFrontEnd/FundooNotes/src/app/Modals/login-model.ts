import { Injectable } from '@angular/core';

 @Injectable()   
export class LoginModel {

    constructor(
     
        public UserEmail: string,
        public Password: string
      
    ) {  }

}
