import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'notesSearch'
})
export class NotesSearchPipe implements PipeTransform {
  
  transform(list: any[], filterText: string): any {
    return list ? list.filter(item => item.title.search(new RegExp(filterText, 'i'))>-1)
    : [];
  }
  /*
  transform(value: any, args?: any): any {
    if(!value)  return null;
   if(!args) return value;

   return value.filter(Array => Array.title.toLowerCase().indexOf(args.toLowerCase()) !==-1 || Array.takeANote.toLowerCase().toLowerCase().indexOf(args.toLowerCase()) !==-1)
  }
  */
}
