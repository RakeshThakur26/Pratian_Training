"use strict";
exports.__esModule = true;
exports.Company = void 0;
var Company = /** @class */ (function () {
    function Company(_name) {
        this.departments = [];
        this.offices = [];
        this.cName = _name;
    }
    Company.prototype.setCName = function (_name) {
        this.cName = _name;
    };
    Company.prototype.getCName = function () {
        return this.cName;
    };
    Company.prototype.setDepartment = function (_dep) {
        this.departments.push(_dep);
    };
    Company.prototype.setOffice = function (_off) {
        this.offices.push(_off);
    };
    Company.prototype.getDepartment = function () {
        return this.departments;
    };
    Company.prototype.getOffice = function () {
        return this.offices;
    };
    return Company;
}());
exports.Company = Company;
