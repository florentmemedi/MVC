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

        public IActionResult Download()
        {
            string path = Path.Combine("`/Images/");
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo[] files = dirInfo.GetFiles("*.*");
            List<string> first = new List<string>(files.Length);
            foreach (var item in files)
            {
                first.Add(item.Name);
            }
            return View(first);
        }

        public IActionResult DownloadFile(string filename)
        {
            if (Path.GetExtension (filename) == ".jpg")
            {
                string fullPath = Path.Combine("`/Images/", filename);
                return File(fullPath, "Images/movie1.jpg");
            }
            return null;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
