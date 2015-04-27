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

        public ActionResult StudentDiaryAS()
        {
            ViewBag.Message = "Student Dagbok - AsGeir.";
            return View();
        }

        public ActionResult StudentDiaryTH()
        {
            ViewBag.Message = "Student Dagbok - Tobias.";
            return View();
        }

        public ActionResult StudentDiaryAG()
        {
            ViewBag.Message = "Student Dagbok - Andreas.";
            return View();
        }

        public PartialViewResult LoadPartialViewWeek(string page)
        {
            if (page == null)
            {
                return PartialView("../Shared/_DiaryWeek17");
            }
            else
            {
                return PartialView(page); 
            }           
        }
    }
}