using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Payxat.Helper
{
    public static class CommonService
    {
        public static LanguageType getCurrentLanguage
        {
            get
            {
                return HttpContext.Current.Request.RequestContext.RouteData.Values["culture"]?.ToString() == "ar" ? LanguageType.Arabic : LanguageType.English;
            }
        }
    }
}