class Customer extends Car{
    constructor(public model, public name:string, public phone:number, instock:boolean, public price:number, public maker:string){
        super(instock, price, model, maker)
    }

    getDetails(){
        return {
            'name': this.name,
            'phone': this.phone,
            'inStock':this.instock,
            'price':this.price,
            'model':this.model,
            'maker':this.maker
        }
    }
}

let cust: Customer = new Customer("Nexon","Anandu R",7012835996,true,1737700,'Tata')