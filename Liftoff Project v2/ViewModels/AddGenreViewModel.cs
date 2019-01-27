using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LiftoffProject.ViewModels
{
    public class AddGenreViewModel
    {
        [Required]
        [Display(Name = "Genre")]
        public string Name { get; set; }
    }
}
