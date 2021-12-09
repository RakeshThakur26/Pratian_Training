import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pipe2',
  templateUrl: './pipe2.component.html',
  styleUrls: ['./pipe2.component.css']
})
export class Pipe2Component implements OnInit {
  today: any = Date.now();
  
  constructor() { }

  ngOnInit(): void {
  }

}
