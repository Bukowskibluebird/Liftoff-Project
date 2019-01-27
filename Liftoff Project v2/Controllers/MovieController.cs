using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LiftoffProject.Models;
using LiftoffProject.ViewModels;
using LiftoffProject.Data;
using Microsoft.EntityFrameworkCore;

namespace LiftoffProject.Controllers
{
    public class MovieController : Controller
    {
        private MovieDbContext context;

        public MovieController(MovieDbContext dbContext)
        {
            context = dbContext;
        }



        // GET: /<controller>/
        public IActionResult Index()
        {
            IList<Movie> movies = context.Movies.Include(context => context.Genre).ToList();
            return View(movies);
        }



        public IActionResult Add()
        {
            AddMovieViewModel addMovieViewModel = new AddMovieViewModel(context.Genres.ToList());
            return View(addMovieViewModel);
        }


        [HttpPost]
        public IActionResult Add(AddMovieViewModel addMovieViewModel)
        {

            if (ModelState.IsValid)
            {
                MovieGenre newMovieGenre = context.Genres.SingleOrDefault(c => c.ID == addMovieViewModel.GenreID);


                // Add the new cheese to my existing cheeses
                Movie newMovie = new Movie
                {
                    Title = addMovieViewModel.Name,
                    StreamingService = addMovieViewModel.StreamingService,
                    Genre = newMovieGenre
                };

                context.Movies.Add(newMovie);
                context.SaveChanges();

                return Redirect("/Movie");
            }

            return View(addMovieViewModel);
        }


    }
}