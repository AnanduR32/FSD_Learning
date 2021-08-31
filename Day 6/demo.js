var id = 1132;
var user_name = 'Anandu';
var colors;
(function (colors) {
    colors[colors["Red"] = 0] = "Red";
    colors[colors["Blue"] = 1] = "Blue";
    colors[colors["Green"] = 2] = "Green";
})(colors || (colors = {}));
var days;
(function (days) {
    days[days["Sunday"] = 1] = "Sunday";
    days[days["Monday"] = 2] = "Monday";
    days[days["Tuesday"] = 3] = "Tuesday";
    days[days["Wednesday"] = 4] = "Wednesday";
    days[days["Thursday"] = 5] = "Thursday";
    days[days["Friday"] = 6] = "Friday";
    days[days["Saturday"] = 7] = "Saturday";
})(days || (days = {}));
console.log(colors.Blue);
console.log(days);
var Car = /** @class */ (function () {
    function Car(instock, price, model, maker) {
        this.price = price;
        this.maker = maker;
        this.instock = instock;
        this.price = price;
        this.model = model;
        this.maker = maker;
    }
    Car.prototype.getDetails = function () {
        return {
            'inStock': this.instock,
            'price': this.price,
            'model': this.model,
            'maker': this.maker
        };
    };
    return Car;
}());
var carObj = new Car(false, 1557000, 'Nexon', 'Tata');
carObj.instock = true;
carObj.price = 1723000;
console.log(carObj.getDetails());
