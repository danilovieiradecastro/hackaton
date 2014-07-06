using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectX.Controllers
{
    public class PostsController : Controller
    {
        //
        // GET: /Posts/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RetornarViewAjax()
        {
            return PartialView("/Views/Posts/Index.cshtml");
        }

	}
}