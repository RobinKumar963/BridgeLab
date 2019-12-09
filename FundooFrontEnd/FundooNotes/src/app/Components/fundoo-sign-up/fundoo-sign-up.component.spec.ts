import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FundooSignUpComponent } from './fundoo-sign-up.component';

describe('FundooSignUpComponent', () => {
  let component: FundooSignUpComponent;
  let fixture: ComponentFixture<FundooSignUpComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FundooSignUpComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FundooSignUpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
