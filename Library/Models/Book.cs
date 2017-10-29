using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Book
    {

        public int Id { get; set; }

        [Display(Name = "Numer ISBN")]
        public string ISBN { get; set; }

        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Display(Name = "Wypożyczona")]
        public bool loaned { get; set; }

        //todo author 
        // todo files 
        // todo tags

    }
}