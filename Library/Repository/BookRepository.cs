using Library.IRepository;
using Library.ViewModels;
using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext _context;

        public BookRepository(LibraryContext context)
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
                return _context.Books
                    .ToList();
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
                return _context.Books
                    .Where(b => b.BookId == id)
                    .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        //Methods to view model
        public BookViewModel CreateBookViewModel(Book book)
        {
            if (book == null)
                return null;

            return new BookViewModel
            {
                ISBN = book.ISBN,
                Title = book.Title,
                Category = book.Category,
                Author = book.Author,
                Loaned = book.Loaned
            };
        }

        public List<BookViewModel> GetAllBooksViewModel()
        {
            List<Book> books = _context.Books.ToList();

            if (books == null)
                return null;

            List<BookViewModel> bookViewModel = new List<BookViewModel>();

            foreach (var book in books)
            {
                bookViewModel.Add(CreateBookViewModel(book));
            }

            return bookViewModel;
        }
    }
}