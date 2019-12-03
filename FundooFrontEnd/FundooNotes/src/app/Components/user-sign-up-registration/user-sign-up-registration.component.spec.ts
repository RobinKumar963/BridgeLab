import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UserSignUpRegistrationComponent } from './user-sign-up-registration.component';

describe('UserSignUpRegistrationComponent', () => {
  let component: UserSignUpRegistrationComponent;
  let fixture: ComponentFixture<UserSignUpRegistrationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserSignUpRegistrationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserSignUpRegistrationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
