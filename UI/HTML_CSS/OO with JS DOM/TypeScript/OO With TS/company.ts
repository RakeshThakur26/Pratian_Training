import { Department } from "./department";
import { Office } from "./ofiice";

export class Company {
    cName: string;
    departments: Department[] = [];
    offices: Office[] = [];

    constructor(_name: string) {
        this.cName = _name;
    }
    setCName(_name: string) {
        this.cName = _name;
    }
    getCName(): string {
        return this.cName ;
    }

    setDepartment(_dep: Department) {
        this.departments.push(_dep);
    }

    setOffice(_off: Office) {
        this.offices.push(_off);
    }


    getDepartment() : Department[] {
      return  this.departments;
    }

    getOffice() : Office[] {
      return  this.offices;
    }

    




}