using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppBasicASP.NetCS.Models;


namespace WebAppBasicASP.NetCS.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            Employee employee = new Employee() { Id = 1, Name = "Anandu R", Email = "ananduraj32@gmail.com" };
            return View(employee);
        }
    }
}