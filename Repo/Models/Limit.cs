using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repo.Models
{
    public class Limit
    {
        public int LimitId { get; set; }

        [Display(Name = "Maksymalna ilość wypożyczonych książek")]
        public int MaxBorrowBooks { get; set; }

        [Display(Name = "Maksymalna ilość oczekujących książek")]
        public int MaxWaitingBooks { get; set; }
    }
}