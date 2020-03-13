using Project_KienTrucMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_KienTrucMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection f)
        {
            SinhVien sv = new SinhVien();
            sv.SVID = Convert.ToInt32(f["txtSVID"]);
            sv.SVTen = f["txtSVTen"];
            sv.SVDiaChi = f["txtSVDiaChi"];
            return View(sv);
        }
    }
}