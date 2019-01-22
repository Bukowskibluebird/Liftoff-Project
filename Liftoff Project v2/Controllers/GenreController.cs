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

    }
}