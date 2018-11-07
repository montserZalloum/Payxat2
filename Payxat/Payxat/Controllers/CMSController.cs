using Payxat.FilterAttributes;
using Payxat.Helper;
using Payxat.Models.CMS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Payxat.Repository;
using Payxat.Repository.DataObject;
using NewAeonTech.Repository;

namespace Payxat.Controllers
{
    //**//
    public class CMSController : Controller
    {
        // GET: CMS
        public ActionResult Index()
        {
            return View();
        }


        [AdminPermissions]
        [HttpGet]
        public ActionResult Images()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AdminPermissions]
        public ActionResult Images(HttpPostedFileBase home ,
                                   HttpPostedFileBase business,
                                   HttpPostedFileBase loyalty,
                                   HttpPostedFileBase howitworks,
                                   HttpPostedFileBase pricing,
                                   HttpPostedFileBase products,
                                   HttpPostedFileBase customeracquistion,
                                   HttpPostedFileBase loyaltyretention,
                                   HttpPostedFileBase marketingautomation,
                                   HttpPostedFileBase promotions,
                                   HttpPostedFileBase lovelocalnetwork,
                                   HttpPostedFileBase smallbusinessmarketing,
                                   HttpPostedFileBase english)
        {
            if (home != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(home.FileName);
                string saveName = Server.MapPath("~/Images") + $"/{imgName}";
                string saveNameDB = $"../Images/{imgName}";
                home.SaveAs(saveName);
                ResourceHelper.AddUpdateResource("imghome", saveNameDB, null);
            }

            if (business != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(business.FileName);
                string saveName = Server.MapPath("~/Images") + $"/{imgName}";
                string saveNameDB = $"../Images/{imgName}";
                business.SaveAs(saveName);
                ResourceHelper.AddUpdateResource("imgbusiness", saveNameDB, null);
            }

            if (loyalty != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(loyalty.FileName);
                string saveName = Server.MapPath("~/Images") + $"/{imgName}";
                string saveNameDB = $"/Payxat/Images/{imgName}";
                loyalty.SaveAs(saveName);
                ResourceHelper.AddUpdateResource("imgloyalty", saveNameDB, null);
            }

            if (howitworks != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(howitworks.FileName);
                string saveName = Server.MapPath("~/Images") + $"/{imgName}";
                string saveNameDB = $"/Payxat/Images/{imgName}";
                howitworks.SaveAs(saveName);
                ResourceHelper.AddUpdateResource("imghowitworks", saveNameDB, null);
            }

            if (pricing != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(pricing.FileName);
                string saveName = Server.MapPath("~/Images") + $"/{imgName}";
                string saveNameDB = $"/Payxat/Images/{imgName}";
                pricing.SaveAs(saveName);
                ResourceHelper.AddUpdateResource("imgpricing", saveNameDB, null);
            }

            if (products != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(products.FileName);
                string saveName = Server.MapPath("~/Images") + $"/{imgName}";
                string saveNameDB = $"/Payxat/Images/{imgName}";
                products.SaveAs(saveName);
                ResourceHelper.AddUpdateResource("imgproducts", saveNameDB, null);
            }

            if (customeracquistion != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(customeracquistion.FileName);
                string saveName = Server.MapPath("~/Images") + $"/{imgName}";
                string saveNameDB = $"/Payxat/Images/{imgName}";
                customeracquistion.SaveAs(saveName);
                ResourceHelper.AddUpdateResource("imgcustomeracquistion", saveNameDB, null);
            }

            if (loyaltyretention != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(loyaltyretention.FileName);
                string saveName = Server.MapPath("~/Images") + $"/{imgName}";
                string saveNameDB = $"/Payxat/Images/{imgName}";
                loyaltyretention.SaveAs(saveName);
                ResourceHelper.AddUpdateResource("imgloyaltyretention", saveNameDB, null);
            }

            if (marketingautomation != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(marketingautomation.FileName);
                string saveName = Server.MapPath("~/Images") + $"/{imgName}";
                string saveNameDB = $"/Payxat/Images/{imgName}";
                marketingautomation.SaveAs(saveName);
                ResourceHelper.AddUpdateResource("imgmarketingautomation", saveNameDB, null);
            }

            if (promotions != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(promotions.FileName);
                string saveName = Server.MapPath("~/Images") + $"/{imgName}";
                string saveNameDB = $"/Payxat/Images/{imgName}";
                promotions.SaveAs(saveName);
                ResourceHelper.AddUpdateResource("imgpromotions", saveNameDB, null);
            }
            
            if (lovelocalnetwork != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(lovelocalnetwork.FileName);
                string saveName = Server.MapPath("~/Images") + $"/{imgName}";
                string saveNameDB = $"/Payxat/Images/{imgName}";
                lovelocalnetwork.SaveAs(saveName);
                ResourceHelper.AddUpdateResource("imglovelocalnetwork", saveNameDB, null);
            }

            if (smallbusinessmarketing != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(smallbusinessmarketing.FileName);
                string saveName = Server.MapPath("~/Images") + $"/{imgName}";
                string saveNameDB = $"/Payxat/Images/{imgName}";
                smallbusinessmarketing.SaveAs(saveName);
                ResourceHelper.AddUpdateResource("imgsmallbusinessmarketing", saveNameDB, null);
            }

            if (english != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(english.FileName);
                string saveName = Server.MapPath("~/Images") + $"/{imgName}";
                string saveNameDB = $"/Payxat/Images/{imgName}";
                english.SaveAs(saveName);
                ResourceHelper.AddUpdateResource("imgenglish", saveNameDB, null);
            }

            return RedirectToAction("Images");
        }




        #region ContactUs

        [HttpGet]
        [AdminPermissions]
        public ActionResult GetContactUsDetails(int id)
        {
            ContactU model = ContactUsRepository.GetContactUs(id).FirstOrDefault();
            if (model == null)
                return RedirectToAction("ContactUs");
            return View(model);
        }

        [HttpGet]
        [AdminPermissions]
        public ActionResult DeleteContactUs(int id)
        {
            ContactUsRepository.RemoveContactUs(id);

            return RedirectToAction("ContactUs");
        }
        [AdminPermissions]
        public ActionResult ContactUs()
        {
            List<ContactU> model = ContactUsRepository.GetContactUs();
            return View(model);
        }
        #endregion




        #region Resources

        [AdminPermissions]
        public ActionResult Resources()
        {
            List<ResourcesModel> resources = GR.GetAllResources();
            return View(resources);
        }

        [HttpPost]
        [AdminPermissions]
        [ValidateInput(false)]
        public ActionResult UpdateReource(ResourceEntry resource)
        {
            GR.AddUpdateResource(resource.ResourceKey, resource.ResourceValueEn, resource.ResourceValueAr);
            return RedirectToAction("Resources");
        }

        
        [AdminPermissions]
        [ValidateInput(false)]
        public ActionResult AddResource(ResourceEntry resource)
        {
            GR.AddUpdateResource(resource.addedResourceKey, resource.addedResourceValueEn, resource.addedResourceValueAr);
            return RedirectToAction("Resources");
        }

        public class ResourceEntry
        {
            public string addedResourceKey { get; set; }
            [AllowHtml]
            public string addedResourceValueEn { get; set; }
            [AllowHtml]
            public string addedResourceValueAr { get; set; }

            public string ResourceKey { get; set; }
            [AllowHtml]
            public string ResourceValueEn { get; set; }
            [AllowHtml]
            public string ResourceValueAr { get; set; }
        }

        
        [AdminPermissions]
        public ActionResult RemoveResource(string id)
        {
            GR.RemoveResource(id);
            return RedirectToAction("Resources");
        }

        [AdminPermissions]
        [HttpGet]
        public ActionResult SocialMedia()
        {
            return View();
        }

        [AdminPermissions]
        [HttpPost]
        public ActionResult SocialMedia(string we_Facebook,
                                        string we_Youtube,
                                        string we_Linkedin,
                                        string we_Twitter,
                                        string we_Instagram,
                                        string we_Google)
        {

            GR.AddUpdateResource("SocialFacebook", we_Facebook, we_Facebook);
            GR.AddUpdateResource("SocialYoutube", we_Youtube, we_Youtube);
            GR.AddUpdateResource("SocialLinkedin", we_Linkedin, we_Linkedin);
            GR.AddUpdateResource("SocialTwitter", we_Twitter, we_Twitter);
            GR.AddUpdateResource("SocialInstagram", we_Instagram, we_Instagram);
            GR.AddUpdateResource("SocialGoogle", we_Google, we_Google);

            return View();
        }

        [HttpGet]
        public ActionResult SpecialCompanyFilter()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ImagesResources()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ImagesResources(HttpPostedFileBase MainSlider1, HttpPostedFileBase MainSlider1Ar,
                                           HttpPostedFileBase MainSlider2, HttpPostedFileBase MainSlider2Ar,
                                           HttpPostedFileBase FirstAds, HttpPostedFileBase FirstAdsAr,
                                           HttpPostedFileBase SecondAds, HttpPostedFileBase SecondAdsAr,
                                           HttpPostedFileBase AdsSlider1, HttpPostedFileBase AdsSlider1Ar,
                                           HttpPostedFileBase AdsSlider2, HttpPostedFileBase AdsSlider2Ar,
                                           HttpPostedFileBase AdsSlider3, HttpPostedFileBase AdsSlider3Ar,
                                           HttpPostedFileBase AboutSlider1, HttpPostedFileBase AboutSlider1Ar,
                                           HttpPostedFileBase AboutSlider2, HttpPostedFileBase AboutSlider2Ar,
                                           HttpPostedFileBase AboutSlider3, HttpPostedFileBase AboutSlider3Ar
            )
        {
            if (MainSlider1 != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(MainSlider1.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                MainSlider1.SaveAs(saveName);
                GR.AddUpdateResource("MainSlider1", saveNameDB, null);
            }

            if (MainSlider1Ar != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(MainSlider1Ar.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                MainSlider1Ar.SaveAs(saveName);
                GR.AddUpdateResource("MainSlider1", null, saveNameDB);
                // we.news_Image = saveNameDB;
            }

            if (MainSlider2 != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(MainSlider2.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                MainSlider2.SaveAs(saveName);
                GR.AddUpdateResource("MainSlider2", saveNameDB, null);
                // we.news_Image = saveNameDB;
            }

            if (MainSlider2Ar != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(MainSlider2Ar.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                MainSlider2Ar.SaveAs(saveName);
                GR.AddUpdateResource("MainSlider2", null, saveNameDB);
                // we.news_Image = saveNameDB;
            }

            if (FirstAds != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(FirstAds.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                FirstAds.SaveAs(saveName);
                GR.AddUpdateResource("FirstAds", saveNameDB, null);
                // we.news_Image = saveNameDB;
            }

            if (FirstAdsAr != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(FirstAdsAr.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                FirstAdsAr.SaveAs(saveName);
                GR.AddUpdateResource("FirstAds", null, saveNameDB);
                // we.news_Image = saveNameDB;
            }

            if (SecondAds != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(SecondAds.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                SecondAds.SaveAs(saveName);
                GR.AddUpdateResource("SecondAds", saveNameDB, null);
                // we.news_Image = saveNameDB;
            }

            if (SecondAdsAr != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(SecondAdsAr.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                SecondAdsAr.SaveAs(saveName);
                GR.AddUpdateResource("SecondAds", null, saveNameDB);
                // we.news_Image = saveNameDB;
            }

            if (AdsSlider1 != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(AdsSlider1.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                AdsSlider1.SaveAs(saveName);
                GR.AddUpdateResource("AdsSlider1", saveNameDB, null);
                // we.news_Image = saveNameDB;
            }

            if (AdsSlider1Ar != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(AdsSlider1Ar.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                AdsSlider1Ar.SaveAs(saveName);
                GR.AddUpdateResource("AdsSlider1", null, saveNameDB);
                // we.news_Image = saveNameDB;
            }

            if (AdsSlider2 != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(AdsSlider2.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                AdsSlider2.SaveAs(saveName);
                GR.AddUpdateResource("AdsSlider2", saveNameDB, null);
                // we.news_Image = saveNameDB;
            }

            if (AdsSlider2Ar != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(AdsSlider2Ar.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                AdsSlider2Ar.SaveAs(saveName);
                GR.AddUpdateResource("AdsSlider2", null, saveNameDB);
                // we.news_Image = saveNameDB;
            }

            if (AdsSlider3 != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(AdsSlider3.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                AdsSlider3.SaveAs(saveName);
                GR.AddUpdateResource("AdsSlider3", saveNameDB, null);
                // we.news_Image = saveNameDB;
            }

            if (AdsSlider3Ar != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(AdsSlider3Ar.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                AdsSlider3Ar.SaveAs(saveName);
                GR.AddUpdateResource("AdsSlider3", null, saveNameDB);
                // we.news_Image = saveNameDB;
            }

            if (AboutSlider1 != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(AboutSlider1.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                AboutSlider1.SaveAs(saveName);
                GR.AddUpdateResource("AboutSlider1", saveNameDB, null);
                // we.news_Image = saveNameDB;
            }

            if (AboutSlider1Ar != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(AboutSlider1Ar.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                AboutSlider1Ar.SaveAs(saveName);
                GR.AddUpdateResource("AboutSlider1", null, saveNameDB);
                // we.news_Image = saveNameDB;
            }

            if (AboutSlider2 != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(AboutSlider2.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                AboutSlider2.SaveAs(saveName);
                GR.AddUpdateResource("AboutSlider2", saveNameDB, null);
                // we.news_Image = saveNameDB;
            }

            if (AboutSlider2Ar != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(AboutSlider2Ar.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                AboutSlider2Ar.SaveAs(saveName);
                GR.AddUpdateResource("AboutSlider2", null, saveNameDB);
                // we.news_Image = saveNameDB;
            }

            if (AboutSlider3 != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(AboutSlider3.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                AboutSlider3.SaveAs(saveName);
                GR.AddUpdateResource("AboutSlider3", saveNameDB, null);
                // we.news_Image = saveNameDB;
            }

            if (AboutSlider3Ar != null)
            {
                string imgName = Guid.NewGuid().ToString() + Path.GetExtension(AboutSlider3Ar.FileName);
                string saveName = Server.MapPath("~/SiteFiles/Images") + $"/{imgName}";
                string saveNameDB = $"/SiteFiles/Images/{imgName}";
                AboutSlider3Ar.SaveAs(saveName);
                GR.AddUpdateResource("AboutSlider3", null, saveNameDB);
                // we.news_Image = saveNameDB;
            }
            //   Repository.LatestNews.AddLatestNews(ref we);


            return RedirectToAction("ImagesResources");
        }


        #endregion

        #region Login

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string userName, string password)
        {

            vmLogin login = new vmLogin();
            login.UserName = userName;
            login.Password = password;
            UsersRepository.Login(userName, password);
            if (UsersRepository.Login(userName, password) != null)
            {
                SessionVariables.InSessionUser = UsersRepository.Login(userName, password).U_ID;
                return RedirectToAction("Index");

            }
            else
            {

                ViewBag.Message = GR.GetString("AdminLoginMessage");


                return View(login);
            }

        }

        public ActionResult Logout()
        {
            SessionVariables.InSessionUser = 0;
            return RedirectToAction("Index");
        }

        #endregion



    }
}