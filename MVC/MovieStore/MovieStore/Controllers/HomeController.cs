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
        private static List<MovieModel> Movies = new List<MovieModel>
        {
            new MovieModel
            {
                Id = 1,
                Title = "Fast & Furious 8",
                Genre = "Action",
                Information = "It is an action movie. Production year: 2017",
                Price = 1600
            },
            new MovieModel
            {
                Id = 2,
                Title = "John Wick 3",
                Genre = "Action",
                Information = "It is an action movie. Production year: 2019",
                Price = 1800
            },
            new MovieModel
            {
                Id = 3,
                Title = "The Revenant",
                Genre = "Drama",
                Information = "It is a movie with drama genre. Production year: 2015",
                Price = 2000
            },
            new MovieModel
            {
                Id = 4,
                Title = "Godzilla",
                Genre = "Fantasy",
                Information = "It is a fantasy movie. Production year: 2019",
                Price = 1200
            },
            new MovieModel
            {
                Id = 5,
                Title = "Glass",
                Genre = "Thriller",
                Information = "It is a movie with thriller genre. Production year: 2019",
                Price = 1100
            }
        };
        public IActionResult Index()
        {

            return View(Movies);
        }

        public IActionResult Edit(int id)
        {
            var movie = Movies.FirstOrDefault(m => m.Id == id);

            return View(movie);
        }
        public IActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public IActionResult SaveChanges(MovieModel movie)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit");
            }
            var index = Movies.FindIndex(i => i.Id == movie.Id);
            Movies[index] = movie;
            return View("Index", Movies);
        }
        [HttpPost]
        public IActionResult Add(MovieModel movie)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Movies.Add(movie);
            return View("Index", Movies);
        }
        public IActionResult Delete(int id)
        {
            var movie = Movies.FirstOrDefault(m => m.Id == id);
            Movies.Remove(movie);
            return View("Index", Movies);
        }
    }
}
