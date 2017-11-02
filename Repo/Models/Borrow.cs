using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repo.Models
{
    public class Borrow
    {
        public int BorrowId { get; set; }

        [Display(Name = "Data wypożyczenia")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{:0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BorrowStart { get; set; }

        [Display(Name = "Data oddania")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{:0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BorrowEnd { get; set; }

        [Display(Name = "Stan wypożyczenia")]
        public string State { get; set; }

        public virtual User User { get; set; }

        public virtual Book Book { get; set; }
    }
}