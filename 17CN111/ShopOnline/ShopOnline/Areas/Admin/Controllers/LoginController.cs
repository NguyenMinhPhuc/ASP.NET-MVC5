using Models.Dao;
using ShopOnline.Areas.Admin.Common;
using ShopOnline.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ShopOnline.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            var result = new AccountModel().Login(model.UserName, model.PassWord);
            if (result && ModelState.IsValid)
            {
                //đăng nhập vào admin
               // SessionHelper.SetSession(new UserSession() { UserName = model.UserName });
                FormsAuthentication.SetAuthCookie(model.UserName, model.RemenberMe);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng");
            }
            return View(model);
        }
        public ActionResult LogOut()
        {
            //SessionHelper.SetSession(null);
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");

        }

    }
}