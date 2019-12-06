import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UserAccountSignUpComponent } from './user-account-sign-up.component';

describe('UserAccountSignUpComponent', () => {
  let component: UserAccountSignUpComponent;
  let fixture: ComponentFixture<UserAccountSignUpComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserAccountSignUpComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserAccountSignUpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
