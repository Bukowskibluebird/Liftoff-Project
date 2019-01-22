using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiftoffProject.Models
{
    public class Movie
    {
        public string Title { get; set; }
        // public string Description { get; set; }
        public int ID { get; set; }
        public MovieGenre Genre { get; set; }
        public int CategoryID { get; set; }

        //public IList<CheeseMenu> CheeseMenus { get; set; }
    }
}
