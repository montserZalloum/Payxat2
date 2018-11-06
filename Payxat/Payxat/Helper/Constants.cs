using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Payxat.Helper
{
    public class Constants
    {
        public static readonly string CookieSystemLanguage = "SystemLanguage";
        public static readonly string ArabicCookieName = "ar-jo";
        public static readonly string EnglishCookieName = "en";
        public static readonly string InSessionUser = "InSessionUser";


        public static readonly string resourcePathEn = AppDomain.CurrentDomain.BaseDirectory + "GlobalResources.resx";
        public static readonly string resourcePathAr = AppDomain.CurrentDomain.BaseDirectory + "GlobalResources.ar.resx";

    }
}