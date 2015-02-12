using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OriginsSchedule.Data;
using OriginsSchedule.Models;


namespace OriginsSchedule.Controllers
{
    public class HomeController : Controller
    {
        private IOriginsScheduleRepository _repo;

        public HomeController (IOriginsScheduleRepository repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
