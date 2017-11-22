using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<BookViewModel> BooksList { get; set; }
        public IEnumerable<MessageViewModel> NewsList { get; set; }
    }
}