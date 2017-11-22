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

        [Display(Name ="Kategoria")]
        public string Category { get; set; }

        [Display(Name = "Wypożyczona")]
        public bool Loaned { get; set; }

        [Display(Name = "Autor")]
        public string Author { get; set; }

        public virtual ICollection<File> File { get; set; }

        public virtual ICollection<Tag> Tag { get; set; }
    }
}