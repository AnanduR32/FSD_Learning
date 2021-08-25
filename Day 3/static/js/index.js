import About from "./views/About.js";
import Home from "./views/Home.js";
import Contact from "./views/Contact.js";
import Projects from "./views/Projects.js";
import Qualifications from "./views/Qualifications.js";

const navigateTo = url => {
    history.pushState(null, null, url);
    router();
}

const router = async()=>{
    const routes = [
        { path: "/", view: Home},
        { path: "/About", view: About},
        { path: "/Projects", view: Projects},
        { path: "/Qualifications", view: Qualifications},
        { path: "/Contact", view: Contact}
    ]

    const potentialMatches = routes.map(route=>{
        return {
            route: route,
            isMatch: location.pathname === route.path
        }
    })
    let match = potentialMatches.find(potentialMatche => potentialMatche.isMatch)

    if(!match){
        match = {
            route: routes[0],
            isMatch: true
        }
    }

    const view = new match.route.view()

    document.querySelector("#app").innerHTML = await view.getHTML()

    // console.log(match.route.view())

}

window.addEventListener("popstate", router)

document.addEventListener("DOMContentLoaded",()=>{
    document.body.addEventListener("click", e=>{
        if(e.target.matches("[data-link]")){
            e.preventDefault()
            navigateTo(e.target.href)
        }
    })
    router()
})