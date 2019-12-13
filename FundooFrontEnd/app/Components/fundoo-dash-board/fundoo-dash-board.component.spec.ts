import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FundooDashBoardComponent } from './fundoo-dash-board.component';

describe('FundooDashBoardComponent', () => {
  let component: FundooDashBoardComponent;
  let fixture: ComponentFixture<FundooDashBoardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FundooDashBoardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FundooDashBoardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
