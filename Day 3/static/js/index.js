const router = async()=>{
    const routes = [
        { path: "/", view: ()=>{console.log("Viewing Dashboard")}},
        { path: "/Login", view: ()=>{console.log("Viewing Login")}},
        { path: "/Employee", view: ()=>{console.log("Viewing Employee")}},
        { path: "/Contact", view: ()=>{console.log("Viewing Contact")}}
    ]

    const potentialMatches = routes.map(route=>{
        return {
            route: route,
            isMatch: location.pathname === route.path
        }
    })
    let match = potentialMatches.find(potentialMatche => potentialMatche.isMatch)
    console.log(potentialMatches)

}

document.addEventListener("DOMContentLoaded",()=>{
    router()
})