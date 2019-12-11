import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserNotesPipe } from './user-notes.pipe';



@NgModule({
  
  declarations: [UserNotesPipe],
  imports: [
    CommonModule
  ]
})
export class CustomPipeModuleModule { }
