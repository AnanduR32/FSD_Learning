const express = require("express")
const path = require("path")

const app = express()

app.use("/static", express.static(path.resolve(__dirname, ".", "static")))
app.use("/assets", express.static(path.resolve(__dirname, ".", "assets")))


app.get("/*",(req, res)=>{
    res.sendFile(path.resolve(__dirname, "frontend","index.html"))
})

const port = process.env.PORT || 32322;
app.listen(port,() => console.log("Server running on ",port))