using Library.IServices;
using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IBookViewModelService _bookViewModelService;

        public HomeController(IBookService bookService, IBookViewModelService bookViewModelService)
        {
            _bookService = bookService;
            _bookViewModelService = bookViewModelService;
        }

        public ActionResult Index()
        {
            
            return View(_bookViewModelService.GetAllBooksViewModel());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}