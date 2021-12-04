"use strict";
exports.__esModule = true;
var company_1 = require("./company");
var department_1 = require("./department");
var employee_1 = require("./employee");
var ofiice_1 = require("./ofiice");
var company1 = new company_1.Company("Pratian");
var office1 = new ofiice_1.Office();
office1.setAddress("Bangalore");
var office2 = new ofiice_1.Office();
office1.setAddress("Chennai");
company1.setOffice(office1);
company1.setOffice(office2);
var dep1 = new department_1.Department();
dep1.setDName("Development");
var dep2 = new department_1.Department();
dep2.setDName("Testing");
var emp1 = new employee_1.Employee();
emp1.setEName("Rakesh");
emp1.setTitle("ASE");
var emp2 = new employee_1.Employee();
emp2.setEName("Sanket");
emp2.setTitle("SE");
var emp3 = new employee_1.Employee();
emp3.setEName("Manoj");
emp3.setTitle("Manager");
var emp4 = new employee_1.Employee();
emp4.setEName("Vybhav");
emp4.setTitle("SE");
dep1.setEmployee(emp2);
dep1.setEmployee(emp3);
dep2.setEmployee(emp1);
dep2.setEmployee(emp4);
company1.setDepartment(dep1);
company1.setDepartment(dep2);
var companies = [];
companies.push(company1);
for (var i = 0; i < companies.length; i++) {
    console.log("Company name : " + companies[i].getCName());
    for (var j = 0; j < companies[i].departments.length; j++) {
        console.log("\tDepartment : " + companies[i].departments[j].getdName());
        console.log("-------------------------------");
        for (var k = 0; k < companies[i].departments[j].employees.length; k++) {
            console.log("\t\tEmployee name: " + companies[i].departments[j].employees[k].name + ", Title : " + companies[i].departments[j].employees[k].getTitle());
        }
    }
    console.log("*********************************************************");
}
