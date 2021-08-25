import AbstractView from "./AbstractView.js";

export default class  extends AbstractView {
    constructor(){
        super()
        this.setTitle("Qualifications")
    }
    async getHTML(){
        return `<section class="section-qualifications">

        </section>`
    }
}
