using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repo.Models
{
    public class Tag
    {
        public int TagId { get; set; }

        [Display(Name = "Tag")]
        public string Content { get; set; }
    }
}