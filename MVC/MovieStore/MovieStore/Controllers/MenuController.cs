using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Models;

namespace MovieStore.Controllers
{
    public class MenuController : Controller
    {
            private static List<MovieModel> movieList = new List<MovieModel>
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
                return View(movieList);
            }
            public IActionResult MovieDetails(int id)
            {
                var movie = movieList.FirstOrDefault(x => x.Id == id);
                return View(movie);
            }

            public IActionResult Edit(int id)
            {
                var movie = movieList.FirstOrDefault(x => x.Id == id);
                return View(movie);
            }

            public IActionResult Add()
            {
                return View();
            }

            public IActionResult Delete(int id)
            {
                var movie = movieList.FirstOrDefault(x => x.Id == id);
                movieList.Remove(movie);
                return View("Index", movieList);
            }

            [HttpPost]
            public IActionResult Add(MovieModel model)
            {

                if (!ModelState.IsValid)
                {
                    return View();
                }

                movieList.Add(model);

                return View("Index", movieList);
            }

            [HttpPost]

            [Route("UpdateMovie")]
            public IActionResult SaveChanges(MovieModel model)
            {

                if (!ModelState.IsValid)
                {
                    return View("Edit");
                }

                var index = movieList.FindIndex(x => x.Id == model.Id);
                movieList[index] = model;

                return View("Index", movieList);
            }
        }
    }