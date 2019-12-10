import { Injectable } from '@angular/core';

 @Injectable()
export class SignUp {

      constructor(
    public UserEmail: string,
    public UserID:string,
    public Password: string,
    public UserName: string,
    public Status:string,
    public CardType: string,
    public ProfileImage?:string,
    
    //public Address?:string
  ) {  }



}
