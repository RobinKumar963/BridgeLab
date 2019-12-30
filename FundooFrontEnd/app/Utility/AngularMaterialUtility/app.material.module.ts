import { NgModule } from '@angular/core';
import { MatButtonModule, MatCheckboxModule, MatToolbarModule, MatChipsModule, MatOptionModule, MatGridListModule, MatProgressBarModule, MatSliderModule, MatSlideToggleModule, MatMenuModule, MatDialogModule, MatSnackBarModule, MatSelectModule, MatInputModule, MatSidenavModule, MatCardModule, MatIconModule, MatRadioModule, MatProgressSpinnerModule, MatTabsModule, MatListModule } from '@angular/material';
import { DragDropModule } from '@angular/cdk/drag-drop';
import { ColorPickerModule } from 'ngx-color-picker';

@NgModule({
    imports: [
        MatButtonModule, MatCheckboxModule, MatToolbarModule, MatChipsModule, MatOptionModule, 
        MatGridListModule, MatProgressBarModule, MatSliderModule, MatSlideToggleModule, MatMenuModule, 
        MatDialogModule, MatSnackBarModule, MatSelectModule, MatInputModule, MatSidenavModule, MatCardModule, 
        MatIconModule, MatRadioModule, MatProgressSpinnerModule, MatTabsModule, MatListModule,DragDropModule,
        ColorPickerModule
    ],
    exports: [
        MatButtonModule, MatCheckboxModule, MatToolbarModule, MatChipsModule, MatOptionModule, 
        MatGridListModule, MatProgressBarModule, MatSliderModule, MatSlideToggleModule, MatMenuModule, 
        MatDialogModule, MatSnackBarModule, MatSelectModule, MatInputModule, MatSidenavModule, MatCardModule, 
        MatIconModule, MatRadioModule, MatProgressSpinnerModule, MatTabsModule, MatListModule,DragDropModule,
        ColorPickerModule
    ],
})
export class AppMaterialModule { }