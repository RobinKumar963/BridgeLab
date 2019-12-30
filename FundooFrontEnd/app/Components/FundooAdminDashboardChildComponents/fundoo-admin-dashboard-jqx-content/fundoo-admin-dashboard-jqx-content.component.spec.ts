import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FundooAdminDashboardJQxContentComponent } from './fundoo-admin-dashboard-jqx-content.component';

describe('FundooAdminDashboardJQxContentComponent', () => {
  let component: FundooAdminDashboardJQxContentComponent;
  let fixture: ComponentFixture<FundooAdminDashboardJQxContentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FundooAdminDashboardJQxContentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FundooAdminDashboardJQxContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
