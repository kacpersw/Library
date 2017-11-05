using Library.IServices;
using Library.ViewModels;
using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Services
{
    public class BookViewModelService : IBookViewModelService
    {
        private readonly LibraryContext _context;

        public BookViewModelService(LibraryContext context)
        {
            _context = context;
        }

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