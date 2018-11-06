using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Payxat.Models.CMS
{
    public class ResourcesModel
    {
        public string ResourceKey { get; set; }

        [AllowHtml]
        public string ValueAr { get; set; }

        [AllowHtml]
        public string ValueEn { get; set; }
    }
}