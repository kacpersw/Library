using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Search
    {
        public int SearchId { get; set; }

        public int BookId { get; set; }

        [Display(Name = "Data wyszukiwania")]
        public DateTime SearchDate { get; set; }

        //todo user
    }
}