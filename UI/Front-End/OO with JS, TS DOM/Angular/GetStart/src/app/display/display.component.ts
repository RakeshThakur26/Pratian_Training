import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-display',
  templateUrl: './display.component.html',
  styleUrls: ['./display.component.css']
})

export class DisplayComponent implements OnInit {
  idNum: number = 1;
  Cobj1: Course = new Course(this.idNum++, "TypeScript", "In-Progress");
  Cobj2: Course = new Course(this.idNum++, "JavaScript", "In-Progress");

  constructor() {
    console.log(this.Cobj1);
    console.log(this.Cobj1.status);
    ;
  }

  ngOnInit(): void {

  }
}

export class Course {
  id: number;
  topicName: string;
  status: string;

  constructor(_id: number, _name: string, _status: string) {
    this.id = _id;
    this.topicName = _name;
    this.status = _status;
  }
}
