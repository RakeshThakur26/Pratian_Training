"use strict";
exports.__esModule = true;
exports.Order = void 0;
var Order = /** @class */ (function () {
    function Order() {
        this.orderItems = [];
        // this.orderId=IdGenerator.orderId;
    }
    Order.prototype.getOrderId = function () {
        return this.orderId;
    };
    Order.prototype.setOrderItem = function (_Oitem) {
        this.orderItems.push(_Oitem);
    };
    Order.prototype.getOrderItems = function () {
        return this.orderItems;
    };
    return Order;
}());
exports.Order = Order;
