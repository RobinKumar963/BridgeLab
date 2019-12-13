import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FundooNotesContentComponent } from './fundoo-notes-content.component';

describe('FundooNotesContentComponent', () => {
  let component: FundooNotesContentComponent;
  let fixture: ComponentFixture<FundooNotesContentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FundooNotesContentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FundooNotesContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
