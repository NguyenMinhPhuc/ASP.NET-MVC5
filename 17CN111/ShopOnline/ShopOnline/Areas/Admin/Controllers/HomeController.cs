﻿using ShopOnline.Areas.Admin.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopOnline.Areas.Admin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            //if (SessionHelper.GetSession() == null)
            //{
            //    return RedirectToAction("Index", "Login");
            //}
            return View();
        }
    }
}