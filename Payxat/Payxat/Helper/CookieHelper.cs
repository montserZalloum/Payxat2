using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Payxat.Helper
{
    public static class CookieHelper
    {
        public static string GetCookieValue(string cookiename)
        {
            string selectedLang = string.Empty;
            var sessionCulture = HttpContext.Current.Request.Cookies[cookiename];
            if (sessionCulture != null)
            {
                selectedLang = sessionCulture.Value;
            }
            else
            {
                selectedLang = null;
            }

            return selectedLang;
        }

        public static bool SetCookieValue(string cookiename, string value, bool NoContainsExpirationTime = false, double expirationtime = 518400)
        {
            if (!string.IsNullOrWhiteSpace(cookiename) && !string.IsNullOrWhiteSpace(value))
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies[cookiename];
                if (cookie == null)
                {
                    cookie = new HttpCookie(cookiename);
                    cookie.HttpOnly = false;
                    if (!NoContainsExpirationTime)
                    {
                        cookie.Expires = DateTime.Now.AddMinutes(expirationtime);
                    }
                    cookie.Value = value;
                    HttpContext.Current.Response.Cookies.Add(cookie);

                    return true;
                }
                else
                {
                    if (!NoContainsExpirationTime)
                    {
                        cookie.Expires = DateTime.Now.AddMinutes(expirationtime);
                    }
                    cookie.Value = value;
                    HttpContext.Current.Response.Cookies.Add(cookie);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public static int GetLanguageIDByCookieName(string CookieName)
        {
            //return the current language through the cookie.
            int LanguageID = (int)LanguageType.Arabic;
            string Language = GetCookieValue(CookieName);
            switch (Language)
            {
                case "ar-jo":
                    LanguageID = (int)LanguageType.Arabic;
                    break;
                case "en":
                    LanguageID = (int)LanguageType.English;
                    break;
                default:
                    LanguageID = (int)LanguageType.English;
                    break;
            }

            //if (SessionVariables.InSessionUser != null)
            //{
            //    SessionVariables.InSessionUser.LanguageID = LanguageID;
            //}
            return LanguageID;
        }

        public static void SetLanguageCookieById(string cookieName, LanguageType languageId)
        {
            string language;

            switch (languageId)
            {
                case LanguageType.English:
                    language = "en";
                    break;
                case LanguageType.Arabic:
                default:
                    language = "ar-jo";
                    break;
            }

            SetCookieValue(cookieName, language);

            //if (SessionVariables.InSessionUser != null)
            //{
            //    SessionVariables.InSessionUser.LanguageID = (int)languageId;
            //}
        }

        public static void SetLanguageCookieById(string cookieName, int languageId)
        {
            SetLanguageCookieById(cookieName, (LanguageType)languageId);
        }

        public static void SetLanguageCookieById(string cookieName, string languageId)
        {
            int languageIdValue = int.Parse(languageId);
            SetLanguageCookieById(cookieName, languageIdValue);
        }
    }

}