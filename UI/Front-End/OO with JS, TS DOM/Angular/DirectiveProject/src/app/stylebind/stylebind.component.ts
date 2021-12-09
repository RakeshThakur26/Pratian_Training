import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-stylebind',
  templateUrl: './stylebind.component.html',
  styleUrls: ['./stylebind.component.css']
})
export class StylebindComponent implements OnInit {
  mystyle = true;
  isStyled = true;

mystyles = {
  color: 'blue' ,
  fontStyle:'italic'
}

  constructor() { }

  ngOnInit(): void {
  }

}
