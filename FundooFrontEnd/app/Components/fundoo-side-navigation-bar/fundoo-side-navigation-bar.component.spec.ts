import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FundooSideNavigationBarComponent } from './fundoo-side-navigation-bar.component';

describe('FundooSideNavigationBarComponent', () => {
  let component: FundooSideNavigationBarComponent;
  let fixture: ComponentFixture<FundooSideNavigationBarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FundooSideNavigationBarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FundooSideNavigationBarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
