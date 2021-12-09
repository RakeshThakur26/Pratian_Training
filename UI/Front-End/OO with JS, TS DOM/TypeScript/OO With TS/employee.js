"use strict";
exports.__esModule = true;
exports.Employee = void 0;
var Employee = /** @class */ (function () {
    function Employee() {
    }
    Employee.prototype.getEName = function () {
        return this.name;
    };
    Employee.prototype.setEName = function (_name) {
        this.name = _name;
    };
    Employee.prototype.getTitle = function () {
        return this.title;
    };
    Employee.prototype.setTitle = function (_title) {
        this.title = _title;
    };
    return Employee;
}());
exports.Employee = Employee;
