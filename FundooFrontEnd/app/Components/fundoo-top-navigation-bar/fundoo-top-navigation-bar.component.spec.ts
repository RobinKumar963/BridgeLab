import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FundooTopNavigationBarComponent } from './fundoo-top-navigation-bar.component';

describe('FundooTopNavigationBarComponent', () => {
  let component: FundooTopNavigationBarComponent;
  let fixture: ComponentFixture<FundooTopNavigationBarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FundooTopNavigationBarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FundooTopNavigationBarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
