using Payxat.Models.CMS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Web;

namespace Payxat.Helper
{

    public static class GR
    {


        public static List<string[]> links = new List<string[]>()
       {
            new string []{"{url:Index}", new System.Web.Mvc.UrlHelper(HttpContext.Current.Request.RequestContext).Action("Index", "Default") },
            new string []{"{url:Businesses}", new System.Web.Mvc.UrlHelper(HttpContext.Current.Request.RequestContext).Action("Businesses", "Default") },
            new string []{"{url:A}", new System.Web.Mvc.UrlHelper(HttpContext.Current.Request.RequestContext).Action("Index", "Default") },
            new string []{"{url:A}", new System.Web.Mvc.UrlHelper(HttpContext.Current.Request.RequestContext).Action("Index", "Default") },
            new string []{"{url:A}", new System.Web.Mvc.UrlHelper(HttpContext.Current.Request.RequestContext).Action("Index", "Default") },
            new string []{"{url:A}", new System.Web.Mvc.UrlHelper(HttpContext.Current.Request.RequestContext).Action("Index", "Default") },
            new string []{"{url:A}", new System.Web.Mvc.UrlHelper(HttpContext.Current.Request.RequestContext).Action("Index", "Default") },
            new string []{"{url:A}", new System.Web.Mvc.UrlHelper(HttpContext.Current.Request.RequestContext).Action("Index", "Default") }

       };


        public static void AddUpdateResource(string key, string valueEn, string valueAr)
        {
            if (valueEn != null)
                ChangeResource(Constants.resourcePathEn, key, valueEn); // Change English Resource Value
            if (valueAr != null)
                ChangeResource(Constants.resourcePathAr, key, valueAr); // Change Arabic Resource Value

        }

        private static Dictionary<string, string> resxEn = null;
        private static Dictionary<string, string> resxAr = null;

        public static string GetResource(string key)
        {
            try
            {
                if (CommonService.getCurrentLanguage == LanguageType.Arabic)
                {
                    if (resxAr == null)
                    {
                        ResXResourceReader resReader = new ResXResourceReader(Constants.resourcePathAr);
                        resxAr = resReader.Cast<DictionaryEntry>().ToDictionary(k => k.Key.ToString(), k => k.Value.ToString());
                        resReader.Close();
                    }

                    return resxAr.ContainsKey(key) ? resxAr[key] : key;
                }
                else
                {
                    if (resxEn == null)
                    {
                        ResXResourceReader resReader = new ResXResourceReader(Constants.resourcePathEn);
                        resxEn = resReader.Cast<DictionaryEntry>().ToDictionary(k => k.Key.ToString(), k => k.Value.ToString());
                        resReader.Close();
                    }

                    return resxEn.ContainsKey(key) ? resxEn[key] : key;
                }

            }
            catch (Exception ex)
            {
                return key;
            }

        }

        public static HtmlString GetString(string resourceName)
        {
            return new HtmlString(GetResource(resourceName));
        }

        private static void ChangeResource(string resourceFilePath, string key, string value)
        {
            foreach (string[] lnk in links)
            {
                value = value.Replace(lnk[0], lnk[1]);
            }


            key = key.Trim();
            var resx = new List<DictionaryEntry>();
            using (var reader = new ResXResourceReader(resourceFilePath))
            {
                resx = reader.Cast<DictionaryEntry>().ToList();
                var existingResource = resx.Where(r => r.Key.ToString() == key).FirstOrDefault();
                if (existingResource.Key == null && existingResource.Value == null) // NEW!
                {
                    resx.Add(new DictionaryEntry() { Key = key, Value = value });
                }
                else // MODIFIED RESOURCE!
                {
                    var modifiedResx = new DictionaryEntry() { Key = existingResource.Key, Value = value };
                    resx.Remove(existingResource);  // REMOVING RESOURCE!
                    resx.Add(modifiedResx);  // AND THEN ADDING RESOURCE!
                }
            }
            using (var writer = new ResXResourceWriter(resourceFilePath))
            {
                resx.ForEach(r =>
                {
                        // Again Adding all resource to generate with final items
                        writer.AddResource(r.Key.ToString(), r.Value.ToString());
                });
                writer.Generate();
            }
            CleareCash();
        }

        private static void CleareCash()
        {
            resxEn = null;
            resxAr = null;
        }

        public static List<ResourcesModel> GetAllResources()
        {
            ResXResourceReader resReaderEn = new ResXResourceReader(Constants.resourcePathEn);
            ResXResourceReader resReaderAr = new ResXResourceReader(Constants.resourcePathAr);
            //List<ResourcesModel> result = resReaderEn.Cast<DictionaryEntry>().Select(k => new ResourcesModel() { ResourceKey = k.Key.ToString(), ValueEn = k.Value.ToString() }).ToList();
            List<ResourcesModel> result = (from resEn in resReaderEn.Cast<DictionaryEntry>()
                                           join resAr in resReaderAr.Cast<DictionaryEntry>() on resEn.Key equals resAr.Key
                                           select new ResourcesModel() { ResourceKey = resEn.Key.ToString(), ValueEn = resEn.Value.ToString(), ValueAr = resAr.Value.ToString() }).ToList();

            resReaderAr.Close();
            resReaderEn.Close();

            return result;
        }

        public static void RemoveResource(string key)
        {
            string resourceFilePathEn = Constants.resourcePathEn;

            var resx = new List<DictionaryEntry>();
            using (var reader = new ResXResourceReader(resourceFilePathEn))
            {
                resx = reader.Cast<DictionaryEntry>().ToList();
                resx.RemoveAll(r => r.Key.ToString() == key || r.Key.ToString().Trim() == "");
            }
            using (var writer = new ResXResourceWriter(resourceFilePathEn))
            {
                resx.ForEach(r =>
                {
                        // Again Adding all resource to generate with final items
                        writer.AddResource(r.Key.ToString().Trim(), r.Value.ToString());
                });
                writer.Generate();
            }

            string resourceFilePathAr = Constants.resourcePathAr;

            resx = new List<DictionaryEntry>();
            using (var reader = new ResXResourceReader(resourceFilePathAr))
            {
                resx = reader.Cast<DictionaryEntry>().ToList();
                resx.RemoveAll(r => r.Key.ToString() == key || r.Key.ToString().Trim() == "");
            }
            using (var writer = new ResXResourceWriter(resourceFilePathAr))
            {
                resx.ForEach(r =>
                {
                        // Again Adding all resource to generate with final items
                        writer.AddResource(r.Key.ToString(), r.Value.ToString());
                });
                writer.Generate();
            }

            CleareCash();
        }




    }
}