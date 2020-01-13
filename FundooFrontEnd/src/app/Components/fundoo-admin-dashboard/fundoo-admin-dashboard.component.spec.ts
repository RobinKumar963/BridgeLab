import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FundooAdminDashboardComponent } from './fundoo-admin-dashboard.component';

describe('FundooAdminDashboardComponent', () => {
  let component: FundooAdminDashboardComponent;
  let fixture: ComponentFixture<FundooAdminDashboardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FundooAdminDashboardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FundooAdminDashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
