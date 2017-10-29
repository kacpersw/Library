using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repo.Models
{
    public class File
    {
        public int FileId { get; set; }

        public byte[] Content { get; set; }
    }
}