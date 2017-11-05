using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.IServices
{
    public interface IBookService
    {
        bool AddBookToDB(Book book);
        IEnumerable<Book> GetAllBooksFromDB();
        Book GetBookById(int id);
    }
}
