using Library.IServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace Library.Services
{
    public class LanguageService : ILanguageService
    {
        public HttpCookie ChangeLanguage(String languageAbbrevation)
        {
            if (languageAbbrevation != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(languageAbbrevation);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(languageAbbrevation);
            }

            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = languageAbbrevation;

            return cookie;
        }
    }
}