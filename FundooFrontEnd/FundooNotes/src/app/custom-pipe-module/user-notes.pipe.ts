import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'userNotes'
})
export class UserNotesPipe implements PipeTransform {

  transform(userFetchedNotes: any,args: any): any {

    return userFetchedNotes.filter(item => userFetchedNotes.some(notedetail => notedetail.args == true));
  }

}
