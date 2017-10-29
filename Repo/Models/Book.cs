using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repo.Models
{
    public class Book
    {

        public int BookId { get; set; }

        [Display(Name = "Numer ISBN")]
        public string ISBN { get; set; }

        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Display(Name = "Wypożyczona")]
        public bool Loaned { get; set; }

        //todo author 
        // todo files 
        // todo tags

    }
}