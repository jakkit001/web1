using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using web1.Models;

namespace web1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Plus(int id)
        {
            int i = id + 10;
            ViewBag.Pluss1 = i;
            return View();
        }
        public IActionResult multiply(int id)
        {
            int i = id * 10;
            ViewBag.multiply1 = i;
            return View();
        }
        [Route("pe/{a}/{b}")]
            public IActionResult Minus(int a,int b)
        {
            int i = a - b;
            ViewBag.minus1 = i;
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult contactpost(IFormCollection values)
        {
            ViewData["name"] = values["name"];
            ViewData["email"] = values["email"];
            ViewData["showalert"] = true;
            return View("Index");

            //return RedirectToAction("Index"); 
        }

        public IActionResult contact2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult contactpost2(contact model)
        {
            ViewData["name"] = model.Name;
            ViewData["email"] = model.Email;
            ViewData["showalert"] = true;
            return View("Index");
        }
    }
}
