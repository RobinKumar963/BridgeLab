import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FundooAdminDashboardContentComponent } from './fundoo-admin-dashboard-content.component';

describe('FundooAdminDashboardContentComponent', () => {
  let component: FundooAdminDashboardContentComponent;
  let fixture: ComponentFixture<FundooAdminDashboardContentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FundooAdminDashboardContentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FundooAdminDashboardContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should display', () => {
    expect(component).toBeTruthy();
  });

});
