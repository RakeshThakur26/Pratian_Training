import { Employee } from "./employee";

export class Department {
    dName: string;
    office: string;
    employees: Employee[] = [];

    getdName(): string {
        return this.dName;
    }
    setDName(_name: string) {
        this.dName = _name;
    }

    getOffice(): string {
        return this.office;
    }
    setOffice(_off: string) {
        this.office = _off;
    }

    getEmployees(): Employee[] {
        return this.employees;
    }

    setEmployee(emp: Employee) {
        this.employees.push(emp);
    }


}