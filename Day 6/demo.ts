let id:number = 1132
let user_name:string = 'Anandu'

enum colors {
    Red, Blue, Green
}
enum days {
    Sunday = 1,
    Monday = 2,
    Tuesday = 3,
    Wednesday = 4,
    Thursday = 5,
    Friday = 6,
    Saturday = 7 
}
console.log(colors.Blue)
console.log(days)

class Car{
    public instock
    private model
    constructor(instock:boolean, public price:number, model:string, private maker:string){
        this.instock = instock
        this.price = price
        this.model = model
        this.maker = maker 
    }
    getDetails(){
        return {
            'inStock':this.instock,
            'price':this.price,
            'model':this.model,
            'maker':this.maker
        }
    }
}
let carObj = new Car(false,1557000,'Nexon','Tata')
carObj.instock = true
carObj.price = 1723000
console.log(carObj.getDetails())