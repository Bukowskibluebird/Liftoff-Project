using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LiftoffProject.Data;
using Microsoft.EntityFrameworkCore;
using LiftoffProject.Models;
using LiftoffProject.ViewModels;

namespace LiftoffProject.Controllers
{
    public class GenreController : Controller
    {
        private readonly MovieDbContext context;
            
        public GenreController(MovieDbContext dbContext)
        {
            context = dbContext;
        }


        public IActionResult Index()
        {
            List<MovieGenre> Genres = context.Genres.ToList();
            return View(Genres);
        }


        public IActionResult Add()
        {
            AddGenreViewModel addGenreViewModel = new AddGenreViewModel();
            return View(addGenreViewModel);
        }


        [HttpPost]
        public IActionResult Add(AddGenreViewModel addGenreViewModel)
        {
            if (ModelState.IsValid)
            {
                // Add the new cheese to my existing cheeses
                MovieGenre newGenre = new MovieGenre
                {
                    Genre = addGenreViewModel.Name
                };

                context.Genres.Add(newGenre);
                context.SaveChanges();

                return Redirect("/Category"); //******needs to redirect to add entry page
            }

            return View(addGenreViewModel);
        }


    }
}