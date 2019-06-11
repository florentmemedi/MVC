using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Models;

namespace MovieStore.Controllers
{
    public class PurchaseController : Controller
    {
        public static List<PurchaseModel> purchases = new List<PurchaseModel>
        {
            new PurchaseModel
            {
                Id = 1,
                PurchaseName = "Purchase One",
                Movie = "The Revenant",
                Quantity = 1,
                Price = 2000,
                User = "Ace A"
            },
            new PurchaseModel
            {
                Id = 2,
                PurchaseName = "Purchase Two",
                Movie = "Fast & Furious 8",
                Quantity = 2,
                Price = 3600,
                User = "Aco B"
            },
            new PurchaseModel
            {
                Id = 3,
                PurchaseName = "Purchase Three",
                Movie = "Godzilla",
                Quantity = 3,
                Price = 3600,
                User = "Aca C"
            }
        };
        public IActionResult Index()
        {
            return View(purchases);
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult PurchaseDetails(int id)
        {
            var purchase = purchases.FirstOrDefault(x => x.Id == id);
            return View(purchase);
        }
    }
}