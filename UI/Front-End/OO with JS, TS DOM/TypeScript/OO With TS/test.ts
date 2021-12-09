import { Company } from "./company";
import { Department } from "./department";
import { Employee } from "./employee";
import { Office } from "./ofiice";


let company1 = new Company("Pratian");

let office1 = new Office();
office1.setAddress("Bangalore");

let office2 = new Office();
office1.setAddress("Chennai");

company1.setOffice(office1);
company1.setOffice(office2);

let dep1 = new Department();
dep1.setDName("Development");

let dep2 = new Department();
dep2.setDName("Testing");

let emp1 = new Employee();
emp1.setEName("Rakesh");
emp1.setTitle("ASE");

let emp2 = new Employee();
emp2.setEName("Sanket");
emp2.setTitle("SE");


let emp3 = new Employee();
emp3.setEName("Manoj");
emp3.setTitle("Manager");

let emp4 = new Employee();
emp4.setEName("Vybhav");
emp4.setTitle("SE");

dep1.setEmployee(emp2);
dep1.setEmployee(emp3);

dep2.setEmployee(emp1);
dep2.setEmployee(emp4);

company1.setDepartment(dep1);
company1.setDepartment(dep2);

let companies:Company[]=[];
companies.push(company1);

// for(var i=0; i<companies.length; i++ ){
//     console.log("Company name : " + companies[i].getCName());
//     for(var j=0; j < companies[i].departments.length; j++)
//     {
//         console.log("\tDepartment : "+ companies[i].departments[j].getdName());
//         console.log("-------------------------------")
//         for(var k=0; k < companies[i].departments[j].employees.length; k++){
//             console.log("\t\tEmployee name: " + companies[i].departments[j].employees[k].name +", Title : "+companies[i].departments[j].employees[k].getTitle())
//         }
//     }
//     console.log("*********************************************************")
// }



