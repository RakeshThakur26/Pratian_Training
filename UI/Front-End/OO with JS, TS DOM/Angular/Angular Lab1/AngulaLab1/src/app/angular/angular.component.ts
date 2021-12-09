import { Component, OnInit } from '@angular/core';
import { Course } from './Course';

@Component({
  selector: 'app-angular',
  templateUrl: './angular.component.html',
  styleUrls: ['./angular.component.css']
})
export class AngularComponent implements OnInit {
  course1 = new Course("TypeScript", 12, "15/11/21", "5/12/21");
  
  constructor() {
    
   }

  ngOnInit(): void {
  }

}
