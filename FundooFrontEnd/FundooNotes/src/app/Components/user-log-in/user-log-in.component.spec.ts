import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UserLogINComponent } from './user-log-in.component';

describe('UserLogINComponent', () => {
  let component: UserLogINComponent;
  let fixture: ComponentFixture<UserLogINComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserLogINComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserLogINComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
