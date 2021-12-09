import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from '../employee.model';
import { EventbindComponent } from '../eventbind/eventbind.component';

@Component({
  selector: 'app-display',
  templateUrl: './display.component.html',
  styleUrls: ['./display.component.css']
})
export class DisplayComponent implements OnInit {

  
  emp :Employee;
  CheckStatus="";
  
  constructor() { 
    this.emp = new Employee();
    if(localStorage.getItem('Employees') != null){
     var res: any =  localStorage.getItem('Employees');
      this.emp = JSON.parse(res);      
      // console.log(emp)
    }

    if(this.emp.status == 'Open'){
      this.CheckStatus = 'red';
    }
     

   else if(this.emp.status == 'In-progress'){
      this.CheckStatus = 'yellow';
    }
    else{
      this.CheckStatus = 'green';
    }
   
  }

  ngOnInit(): void {
  }

}
