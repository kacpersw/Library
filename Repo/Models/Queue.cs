using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repo.Models
{
    public class Queue
    {
        public int QueueId { get; set; }
        
        public virtual Book Book { get; set; }
        
        public virtual IEnumerable<User> User { get; set; }
    }
}