import { Component, OnInit } from '@angular/core';
import { Employee } from '../Employee';

@Component({
  selector: 'app-system-allocation',
  templateUrl: './system-allocation.component.html',
  styleUrls: ['./system-allocation.component.css']
})
export class SystemAllocationComponent implements OnInit {
  // red = 'red';
  employees: Employee[] = [];

  constructor() {
    let emp1 = new Employee("Rakesh","Active","Approved","Mac","111");  
    let emp2 = new Employee("Sanket","Active","Yet-to-approve","Iphone","x2");
    let emp3 = new Employee("Manoj","Resigned","Rejected","Redmi","4");
    let emp4 = new Employee("Vybhav","Active","Rejected","NULL","NULL");
    let emp5 = new Employee("Nagendra","Resigned","Yet-to-approve","Mi Notebook","14");

    this.employees.push(emp1);
    this.employees.push(emp2);
    this.employees.push(emp3);
    this.employees.push(emp4);
    this.employees.push(emp5);
   }

  ngOnInit(): void {
  }

}
