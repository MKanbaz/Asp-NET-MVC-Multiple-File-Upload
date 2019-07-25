﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultipleFileUpload.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MultipleUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MultipleUpload(HttpPostedFileBase[] files)
        {
            if (files != null)
            {
                foreach (HttpPostedFileBase file in files)
                {
                    file.SaveAs(Server.MapPath("~/Upload/" + file.FileName));
                    ViewBag.State += "<br>" + file.FileName + " File Uploaded...";
                }
            }
            return View();
        }
    }
}