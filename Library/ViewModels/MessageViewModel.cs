using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.ViewModels
{
    public class MessageViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Username { get; set; }
    }
}