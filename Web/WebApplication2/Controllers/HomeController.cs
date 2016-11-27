using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SakaryaTarihi()
        {
            ViewBag.Message = "Sakarya Tarihi";
            return View();
        }
        public ActionResult KültürelHaberler()
        {
            ViewBag.Message = "Kültürel Haberler";
            return View();
        }
        public ActionResult cafeler()
        {
            ViewBag.Message = "cafeler";
            return View();
        }
        public ActionResult Giris()
        {
            ViewBag.Message = "Giris";
            return View();
        }
        public ActionResult Sinema()
        {
            ViewBag.Message = "Sinema";
            return View();
        }
        public ActionResult Oteller()
        {
            ViewBag.Message = "Oteller";
            return View();
        }
        public ActionResult Sahaflar()
        {
            ViewBag.Message = "Sahaflar";
            return View();
        }
        public ActionResult DogalYerler()
        {
            ViewBag.Message = "Doğal Yerler";
            return View();
        }
    }
}