import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-class-bind',
  templateUrl: './class-bind.component.html',
  styleUrls: ['./class-bind.component.css']
})
export class ClassBindComponent implements OnInit {
  myclass = 'red';
  isClassed = true;
  isItalic = true;

  myclasses = {
    'green': this.isItalic,
    'red': !this.isItalic    
  }

  constructor() { }

  ngOnInit(): void {
  }

}
