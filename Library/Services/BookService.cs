using Library.IServices;
using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Services
{
    public class BookService : IBookService
    {
        private readonly LibraryContext _context;

        public BookService(LibraryContext context)
        {
            _context = context;
        }

        public bool AddBookToDB(Book book)
        {
            try
            {
                _context.Books.Add(book);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Book> GetAllBooksFromDB()
        {
            try
            {
                return _context.Books.ToList();
            }
            catch
            {
                return null;
            }
        }

        public Book GetBookById(int id)
        {
            try
            {
                return _context.Books.Where(b => b.BookId == id)
                    .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
    }
}