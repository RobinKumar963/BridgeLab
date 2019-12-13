import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UserAddNotesComponent } from './user-add-notes.component';

describe('UserAddNotesComponent', () => {
  let component: UserAddNotesComponent;
  let fixture: ComponentFixture<UserAddNotesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserAddNotesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserAddNotesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
