"use strict";
exports.__esModule = true;
exports.Company = void 0;
var Company = /** @class */ (function () {
    function Company(_name) {
        this.customers = [];
        this.Cname = _name;
    }
    Company.prototype.getName = function () {
        return this.Cname;
    };
    Company.prototype.getCustomerById = function (id) {
        // this.customers.map((customer) => {
        //     if(customer.getCustomerId() == id)
        //         return customer;           
        // });
        for (var i = 0; i < this.customers.length; i++) {
            if (this.customers[i].getCustomerId() == id)
                return this.customers[i];
            else
                console.log("Customer is not there with id = " + id);
        }
    };
    Company.prototype.getTotalWorthOfOrderPlaced = function () {
        var total = 0;
        this.customers.map(function (customer) {
            customer.orders.map(function (order) {
                order.orderItems.map(function (Oitem) {
                    total += (Oitem.quantity * Oitem.item.getPrice());
                });
            });
        });
        return total;
    };
    return Company;
}());
exports.Company = Company;
