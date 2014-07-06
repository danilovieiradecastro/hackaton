using ProjectX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectX.Controllers
{
    public class DescribePlaceController : Controller
    {
        //
        // GET: /DescribePlace/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RetornarViewAjax(String Id)
        {
            ViewModelPost model = new ViewModelPost();
            int id = Convert.ToInt32(Id);
            using (var db = new EsquentaContainerContext())
            {
                model.ListaBaladas = db.LocalSets.Where(x => x.Id == id).ToList();
            }
            return PartialView("/Views/DescribePlace/Index.cshtml", model);
        }
	}
}