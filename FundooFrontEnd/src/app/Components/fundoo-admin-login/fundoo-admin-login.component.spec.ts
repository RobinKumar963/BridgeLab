import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FundooAdminLoginComponent } from './fundoo-admin-login.component';

describe('FundooAdminLoginComponent', () => {
  let component: FundooAdminLoginComponent;
  let fixture: ComponentFixture<FundooAdminLoginComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FundooAdminLoginComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FundooAdminLoginComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
