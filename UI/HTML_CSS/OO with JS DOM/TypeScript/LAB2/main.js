"use strict";
exports.__esModule = true;
var Company_1 = require("./Company");
var Customer_1 = require("./Customer");
var RegCustomer_1 = require("./RegCustomer");
var company = new Company_1.Company("Eurofins");
var reg = new RegCustomer_1.RegCustomer("Rakesh", 10);
var cust = new Customer_1.Customer("Rakesh");
company.customers.push(reg);
company.customers.push(cust);
company.customers.map(function (customer) {
    console.log(customer.className == "RegCustomer");
});
// console.log("Total number of customers = " + company.customers.length);
// console.log("*************************************************\n");
// console.log("Total money earned by the company from each order");
// company.customers.map((customer) => {
//     customer.orders.map((order) => {
//         console.log(order.orderId);
//         order.orderItems.map((Oitem) => {
//             console.log("\t" + (Oitem.getQuantity() * Oitem.item.getPrice()));
//         });
//     });
//     console.log("---------------------------------------");
// });
