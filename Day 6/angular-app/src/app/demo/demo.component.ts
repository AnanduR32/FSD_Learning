import { Component } from "@angular/core";

@Component({
    selector: 'demo-component',
    templateUrl: 'demo.template.html',
    styleUrls: ['demo.styles.css']
})
export default class DemoComponent{
    inputText:string
    hasError:boolean
    constructor(){
        this.inputText = ""
        this.hasError = false
    }
    onchangeText(){
        if(this.inputText.length>=11){
            this.hasError = true
        }
        else{
            this.hasError = false
        }
    }
}