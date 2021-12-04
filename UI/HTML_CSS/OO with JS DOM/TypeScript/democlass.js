"use strict";
exports.__esModule = true;
exports.Democlass = void 0;
var Democlass = /** @class */ (function () {
    function Democlass(_topic, _id, _status) {
        this.id = _id;
        this.status = _status;
        this.topic = _topic;
    }
    Democlass.prototype.showTopic = function () {
        console.log("".concat(this.topic, " has status: ").concat(this.status));
    };
    return Democlass;
}());
exports.Democlass = Democlass;
