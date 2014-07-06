using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectX.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Teste()
        {
            string anonimo = Request["hdnAnonimo"];
            string desc = Request["hdnDescricao"];
            string local = Request["hdnLocal"];
            string qtd = Request["hdnQtd"];
            string qld = Request["hdnQld"];

            return View();
        }
    }
}