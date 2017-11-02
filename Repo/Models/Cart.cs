using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repo.Models
{
    public class Cart
    {
        public int CartId { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}