import AbstractView from "./AbstractView.js";

export default class  extends AbstractView {
    constructor(){
        super()
        this.setTitle("Projects")
    }
    async getHTML(){
        return `<section class="section-projects">
        <div class="section-projects-header">
            <h3>🤺 Datascientist | UI/UX Designer | Android Developer 🦉</h3>
            <h4><i>Deciphering the singularity</i></h4>
        </div>
        <div class="section-projects-content">
            <div class="section-projects-content-block">
                <h4>About me</h4>
                <ul class="section-projects-content-left">
                    <li>👾 A technology enthusiast that has answers to it all. </li>
                    <li>🦈 Check out my portfolio website - <a
                            href="https://anandur32.github.io/Resume32R/">Resume32R</a>
                    </li>
                    <li>📚 Read some of my <a href="https://aquaregis32.medium.com/">medium</a> posts </li>
                    <li>📫 Reach out to me on <a href="https://twitter.com/AquaRegis32">Twitter</a> or <a
                            href="https://www.linkedin.com/in/anandur32/">LinkedIn</a>, let's talk business</li>
                </ul>
            </div>
            <div class="section-projects-content-block">
                <h4>Check out my datascience projects</h4>
                <ul class="section-projects-content-right">
                    <li>
                        <a href="https://www.kaggle.com/aquaregis32">
                            <img
                                src="https://cdn3.iconfinder.com/data/icons/logos-and-brands-adobe/512/189_Kaggle-512.png">
                            Kaggle
                        </a>
                    </li>
                    <li>
                        <a href="https://rpubs.com/aquaregis32/">
                            <img
                                src="https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSTOj5Z1YZnSJisLbLFCy-RVV_B4fmB1JGvaA&usqp=CAU">
                            rpubs
                        </a>
                    </li>
                    <li>
                        <a href="https://github.com/AnanduR32/Datascience">
                            <img src="https://www.flaticon.com/svg/static/icons/svg/25/25231.svg">
                            Github Datascience repo
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </section>`
    }
}
