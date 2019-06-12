using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Models;
using System.IO;

namespace MovieStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Information for Movie Store.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Movie Store.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
