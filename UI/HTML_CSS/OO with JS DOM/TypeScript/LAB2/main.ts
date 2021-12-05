import { Company } from "./Company";
import { Customer } from "./Customer";
import { RegCustomer } from "./RegCustomer";

let company = new Company("Eurofins");



let reg = new RegCustomer("Rakesh", 10);
let cust = new Customer("Rakesh");

company.customers.push(reg);
company.customers.push(cust);

console.log("*************************************************\n");
console.log("Total number of orders of each Registered customer");
company.customers.map((customer) => {
    if(customer.className == "RegCustomer"){
        console.log(customer.getName() + " = " + customer.getOrders().length);
    }
    console.log("---------------------------------------");
});

console.log("*************************************************\n");
console.log("Total number of customers = " + company.customers.length);
console.log("*************************************************\n");
console.log("Total money earned by the company from each order");
company.customers.map((customer) => {
    customer.orders.map((order) => {
        console.log(order.orderId);
        order.orderItems.map((Oitem) => {
            console.log("\t" + (Oitem.getQuantity() * Oitem.item.getPrice()));
        });
    });
    console.log("---------------------------------------");
});