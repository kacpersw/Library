using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repo.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Display(Name = "Imię")]
        public string Name { get; set; }

        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }

    }
}