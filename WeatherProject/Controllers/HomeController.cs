using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherProject.Models.ViewModels;
using WeatherProject.Services;

namespace WeatherProject.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public HomeController()
        {

        }

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
    }
}