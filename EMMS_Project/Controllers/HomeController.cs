using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMMS_Project.Models;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using EMMS_Project.Abstract;

namespace EMMS_Project.Controllers
{
    public class HomeController : Controller
    {
        private INormalRepository repository;
        public HomeController(INormalRepository repo)
        {
            repository = repo;
        }
        public ActionResult Index()
        {
            List<User> lstUser = (List<User>)repository.UserData;
            ViewBag.UserData = lstUser;
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