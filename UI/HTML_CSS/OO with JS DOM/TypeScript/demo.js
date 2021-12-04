"use strict";
// console.log("Started with TypeScript")
exports.__esModule = true;
var democlass_1 = require("./democlass");
// function sum(... args) : number{
//     var total: number=0;
//     args.map((val) =>{
//         total+=val;
//     }) ;
//     return total;
// }
// console.log(sum(1,2,3,4,5,6));
// interface Filter{
//     filter(...args:number[]):number[];
// }
// let filtervalue:Filter = {
//     filter(...args:number[]){
//         return args.filter((val) => {
//             return val === 7;
//         });
//     }
// };
// console.log(filtervalue.filter(12,3,4,5,6,7,8,9,7,4))
var dataobj = new democlass_1.Democlass("TypeScript", 123, "In-progress");
dataobj.showTopic();
