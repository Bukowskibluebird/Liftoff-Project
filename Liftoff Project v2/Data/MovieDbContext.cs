using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiftoffProject.Controllers;
using LiftoffProject.Models;
using Microsoft.EntityFrameworkCore;

namespace LiftoffProject.Data
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieGenre> Genres { get; set; }

        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<CheeseMenu>()
        //        .HasKey(c => new { c.CheeseID, c.MenuID });
        //}

        //public static implicit operator CheeseDbContext(MenuController v)
        //{
        //   throw new NotImplementedException();
        //}



        //public class ToDoContextFactory : IDesignTimeDbContextFactory<MovieDbContext>
        //{
        //    public AppContext CreateDbContext(string[] args)
        //    {
        //        var builder = new DbContextOptionsBuilder<AppContext>();
        //        builder.UseSqlServer("Server=localhost;Database=DbName;Trusted_Connection=True;MultipleActiveResultSets=true");
        //        return new AppContext(builder.Options);
        //    }
        //}

    }
}
