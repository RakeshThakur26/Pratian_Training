import { Component, OnInit } from '@angular/core';
import { AvailableSystem } from '../AvailableSystem';

@Component({
  selector: 'app-available-systems',
  templateUrl: './available-systems.component.html',
  styleUrls: ['./available-systems.component.css']
})
export class AvailableSystemsComponent implements OnInit {
  systems : AvailableSystem[] =[];
  constructor() {
    let system1 = new AvailableSystem('Macbook', '123');
    let system2 = new AvailableSystem('Iphone', '12');
    let system3 = new AvailableSystem('Redmi', '4');
    let system4 = new AvailableSystem('Realme', '5');
    let system5 = new AvailableSystem('Poco', 'M2');
    let system6 = new AvailableSystem('Moto', 'G3');
    let system7 = new AvailableSystem('Mi Notebook', '14');
    let system8 = new AvailableSystem('xyz', '3');
    this.systems.push(system1);
    this.systems.push(system2);
    this.systems.push(system3);
    this.systems.push(system4);
    this.systems.push(system5);
    this.systems.push(system6);
    this.systems.push(system7);
    this.systems.push(system8);
   }

  ngOnInit(): void {
  }

}
