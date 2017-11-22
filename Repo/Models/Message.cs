using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repo.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public virtual User User { get; set; }
    }
}