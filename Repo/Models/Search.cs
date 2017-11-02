using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repo.Models
{
    public class Search
    {
        public int SearchId { get; set; }

        [Display(Name = "Data wyszukiwania")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{:0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime SearchDate { get; set; }

        public virtual User User { get; set; }

        public virtual Book Book { get; set; }
    }
}