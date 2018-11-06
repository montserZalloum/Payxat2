using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Payxat.Helper
{
    public class SessionVariables
    {
        public static int InSessionUser
        {
            get
            {
                return HttpContext.Current == null ? 0 : (HttpContext.Current.Session == null ? 0 : (int)(HttpContext.Current.Session[Constants.InSessionUser]??0));
            }
            set
            {
                if (HttpContext.Current.Session != null)
                {
                    HttpContext.Current.Session[Constants.InSessionUser] = value;
                }
            }
        }
    }

}