using Library.IServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class LanguageController : Controller
    {
        private readonly ILanguageService _languageService;

        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        public ActionResult Change(String LanguageAbbrevation)
        {
            Response.Cookies.Add(_languageService.ChangeLanguage(LanguageAbbrevation));

            return RedirectToAction("Index", "Home");
        }
    }
}