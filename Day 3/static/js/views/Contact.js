import AbstractView from "./AbstractView.js";

export default class  extends AbstractView {
    constructor(){
        super()
        this.setTitle("Contact")
    }
    async getHTML(){
        return `<section class="section-contacts">
    <div class="section-contacts-header">
        <h1>Contact Me</h1>
    </div>
    <div class="social-icons">
        <div class="social-icon">
            <a href="https://www.linkedin.com/in/anandur32" target="_blank"><i
                    class="icon ion-logo-linkedin"></i></a>
        </div>

        <div class="social-icon">
            <a href="https://github.com/AnanduR32" target="_blank"><i class="icon ion-logo-github"></i></a>
        </div>

        <div class="social-icon">
            <a href="https://twitter.com/aquaregis32" target="_blank"><i class="icon ion-logo-twitter"></i></a>
        </div>

        <div class="social-icon">
            <a href="https://www.instagram.com/aquaregis32/" target="_blank"><i
                    class="icon ion-logo-instagram"></i></a>
        </div>

        <div class="social-icon">
            <a href="https://www.tumblr.com/blog/anandur32" target="_blank"><i
                    class="icon ion-logo-tumblr"></i></a>
        </div>

        <div class="social-icon">
            <a href="https://in.pinterest.com/ananduraj32/" target="_blank"><i
                    class="icon ion-logo-pinterest"></i></a>
        </div>
    </div>

    <p>If you ever wish to get in touch and grab a drink or two, contact me on my social networking
        profiles or contact me personally via email below.</p>

    <div class="contact-button-container">
        <div class='contact-button'>
            <a href="https://mail.google.com/mail/?view=cm&fs=1&to=ananduraj32@gmail.com"
                target="_blank">Contact Me</a>
        </div>
    </div>

    </a>
</section>`
    }
}
