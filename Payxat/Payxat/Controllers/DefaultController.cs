using NewAeonTech.Repository;
using Payxat.Repository.DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Payxat.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Businesses()
        {
            return View();
        }

        public ActionResult Loyalty()
        {
            return View();
        }

        public ActionResult HowItWorks()
        {
            return View();
        }

        public ActionResult Pricing()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }

        public ActionResult CustomerAcquisition()
        {
            return View();
        }

        public ActionResult LoyaltyRetention()
        {
            return View();
        }


        public ActionResult MarketingAutomation()
        {
            return View();
        }


        public ActionResult LoveLocalNetwork()
        {
            return View();
        }

        public ActionResult SmallBusinessMarketing()
        {
            return View();
        }

        public ActionResult English()
        {
            return View();
        }

        public ActionResult Legal()
        {
            return View();
        }
        public ActionResult Privacy()
        {
            return View();
        }

        public ActionResult Promotion()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public ActionResult AddProject(ContactU contactUs)
        {
            ContactUsRepository.AddContactUs(ref contactUs);
           // TempData["ShowMessage"] = Resources.GR.GetString("AddProjectSuccfullyMsg");
           // var model = new NewAeonWebsite.Models.vmIndex();
           // model.whatWeDo = Repository.WhatWeDoRepository.GetWhatWeDoes();
            return RedirectToAction("Legal");
        }

        [ValidateAntiForgeryToken]
        public ActionResult AddProjectC(ContactU contactUs)
        {
            ContactUsRepository.AddContactUs(ref contactUs);
           // TempData["ShowMessage"] = Resources.GR.GetString("AddProjectSuccfullyMsg");
            return RedirectToAction("Legal");
        }
    }
}