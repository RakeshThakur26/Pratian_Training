import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from '../employee.model';

@Component({
  selector: 'app-eventbind',
  templateUrl: './eventbind.component.html',
  styleUrls: ['./eventbind.component.css']
})
export class EventbindComponent implements OnInit {
emp:Employee= new Employee();

  constructor(private routes:Router) { }

  ngOnInit(): void {
  }

  employeeNameFun(e:any){
    this.emp.name = e.target.value;
  }
  employeeProjFun(e:any){
    this.emp.project = e.target.value;
  }
  clickFun(){
    console.log(this.emp)
    localStorage.setItem('Employees', JSON.stringify(this.emp));
    this.routes.navigate(['display']);
  }

}
