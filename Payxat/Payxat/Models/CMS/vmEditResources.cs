using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Payxat.Models.CMS
{
    public class vmEditResources
    {
        public string language { set; get; }
        public List<ResourceItem> resourceItems { get; set; }
    }

    public class ResourceItem
    {
        public string key { get; set; }
        public string value { get; set; }

    }

}