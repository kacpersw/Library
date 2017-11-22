using Library.ViewModels;
using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.IRepository
{
    public interface IBookRepository
    {
        bool AddBookToDB(Book book);
        IEnumerable<Book> GetAllBooksFromDB();
        Book GetBookById(int id);

        BookViewModel CreateBookViewModel(Book book);
        List<BookViewModel> GetAllBooksViewModel();
    }
}
