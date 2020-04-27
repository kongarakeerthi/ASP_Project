using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CAS_Repo;
//using CAS_DAL;
using CAS_Project;

namespace CAS_Web.Controllers
{
    public class DemoController : Controller { 

        private readonly ILogin _l;

        public DemoController()
        {

        }

        public DemoController(ILogin l)
        {
            this._l = l;
        }

        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Homepage()
        {
            return View();
        }
        public ActionResult Homepage1()
        {
            return View();
        }
        public ActionResult Homepage2()
        {
            return View();
        }
        public ActionResult Homepage3()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login model)
        {
            Login user = _l.ValidateUser(model.Username, model.Password);
            if (user == null)
            {
                ViewBag.Error = "Invalid Credentials";
                return View(model);

            }
            else
            {
                Session["User"] = user.Username;
                return RedirectToAction("Page");

            }

        }

        public ActionResult Page()
        {
            return View();
        }
    }
}