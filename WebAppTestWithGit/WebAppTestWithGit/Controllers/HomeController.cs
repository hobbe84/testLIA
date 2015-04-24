using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppTestWithGit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Om denna site.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontaktuppgifter.";

            return View();
        }

        public ActionResult Studentinfo()
        {
            ViewBag.Message = "Student Info.";

            return View();
        }

        public ActionResult StudentDiary()
        {
            ViewBag.Message = "Student Dagbok.";
            return View();
        }

        public ActionResult LoadPartialViewWeek18()
        {
            return View("_DiaryWeek18");
        }
    }
}