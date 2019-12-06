import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UserAccountsSignUpComponent } from './user-accounts-sign-up.component';

describe('UserAccountsSignUpComponent', () => {
  let component: UserAccountsSignUpComponent;
  let fixture: ComponentFixture<UserAccountsSignUpComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserAccountsSignUpComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserAccountsSignUpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
