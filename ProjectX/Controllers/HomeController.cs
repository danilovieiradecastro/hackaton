using ProjectX.Models;
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
            List<PlacesViewModel> placesViewModel;

            using (EsquentaContainerContext context = new EsquentaContainerContext())
            {
                placesViewModel = context.LocalSets.Select(i => new PlacesViewModel() 
                                                                        {
                                                                            Name = i.Nome,
                                                                            Lat = i.Latitude.ToString(),
                                                                            Lon = i.Longitude.ToString(),
                                                                        }).ToList();    
            }

            return View(placesViewModel);
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