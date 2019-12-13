import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UserAccountsLogInComponent } from './user-accounts-log-in.component';

describe('UserAccountsLogInComponent', () => {
  let component: UserAccountsLogInComponent;
  let fixture: ComponentFixture<UserAccountsLogInComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserAccountsLogInComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserAccountsLogInComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
