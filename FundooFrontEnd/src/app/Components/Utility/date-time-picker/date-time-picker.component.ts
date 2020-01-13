import { Component, OnInit } from '@angular/core';
import {NgbDateStruct, NgbCalendar} from '@ng-bootstrap/ng-bootstrap';
@Component({
  selector: 'app-date-time-picker',
  templateUrl: './date-time-picker.component.html',
  styleUrls: ['./date-time-picker.component.scss']
})
export class DateTimePickerComponent implements OnInit {

  constructor(private calendar: NgbCalendar) { }

  model: NgbDateStruct;
  date: {year: number, month: number};

  ngOnInit() {
  }

  selectToday() {
    this.model = this.calendar.getToday();
  }

}
