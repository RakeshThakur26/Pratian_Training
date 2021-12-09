var PriceCalculator;
(function (PriceCalculator) {
    function OrderPrice(orderAmount, discount) {
        return orderAmount - discount;
    }
    PriceCalculator.OrderPrice = OrderPrice;
})(PriceCalculator || (PriceCalculator = {}));
/// <reference path = "./PriceCalc.ts" />  
let totalOrderPrice = PriceCalculator.OrderPrice(500, 150);
console.log('Total price of the order is: ' + totalOrderPrice);
