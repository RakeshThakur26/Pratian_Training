"use strict";
exports.__esModule = true;
exports.Office = void 0;
var Office = /** @class */ (function () {
    function Office() {
    }
    Office.prototype.getAddress = function () {
        return this.address;
    };
    Office.prototype.setAddress = function (add) {
        this.address = add;
    };
    return Office;
}());
exports.Office = Office;
