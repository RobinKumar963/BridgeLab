import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FundooAdminTopNavigationBarComponent } from './fundoo-admin-top-navigation-bar.component';

describe('FundooAdminTopNavigationBarComponent', () => {
  let component: FundooAdminTopNavigationBarComponent;
  let fixture: ComponentFixture<FundooAdminTopNavigationBarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FundooAdminTopNavigationBarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FundooAdminTopNavigationBarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
