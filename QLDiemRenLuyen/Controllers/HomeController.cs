using QLDiemRenLuyen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLDiemRenLuyen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISinhVienService _svService;
        public HomeController(ISinhVienService svService)
        {
            _svService = svService;
        }
        public HomeController()
        {

        }
        public ActionResult Index()
        {
            var data = _svService.Get();
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
    }
}