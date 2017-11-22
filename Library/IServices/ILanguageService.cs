using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Library.IServices
{
    public interface ILanguageService
    {
        HttpCookie ChangeLanguage(String languageAbbrevation);
    }
}
