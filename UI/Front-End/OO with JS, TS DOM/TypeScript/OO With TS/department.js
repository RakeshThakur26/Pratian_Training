"use strict";
exports.__esModule = true;
exports.Department = void 0;
var Department = /** @class */ (function () {
    function Department() {
        this.employees = [];
    }
    Department.prototype.getdName = function () {
        return this.dName;
    };
    Department.prototype.setDName = function (_name) {
        this.dName = _name;
    };
    Department.prototype.getOffice = function () {
        return this.office;
    };
    Department.prototype.setOffice = function (_off) {
        this.office = _off;
    };
    Department.prototype.getEmployees = function () {
        return this.employees;
    };
    Department.prototype.setEmployee = function (emp) {
        this.employees.push(emp);
    };
    return Department;
}());
exports.Department = Department;
