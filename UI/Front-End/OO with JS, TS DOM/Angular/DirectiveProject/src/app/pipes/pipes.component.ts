import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pipes',
  templateUrl: './pipes.component.html',
  styleUrls: ['./pipes.component.css']
})
export class PipesComponent implements OnInit {

  total = 1234521.7655;
  arr = [1,2,3,4,5,6];
  
  constructor() { }

  ngOnInit(): void {
  }

}
