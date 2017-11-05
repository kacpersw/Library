using Library.ViewModels;
using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.IServices
{
    public interface IBookViewModelService
    {
        BookViewModel CreateBookViewModel(Book book);
        List<BookViewModel> GetAllBooksViewModel();
    }
}