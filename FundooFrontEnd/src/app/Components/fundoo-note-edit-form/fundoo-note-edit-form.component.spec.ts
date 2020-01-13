import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FundooNoteEditFormComponent } from './fundoo-note-edit-form.component';

describe('FundooNoteEditFormComponent', () => {
  let component: FundooNoteEditFormComponent;
  let fixture: ComponentFixture<FundooNoteEditFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FundooNoteEditFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FundooNoteEditFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
