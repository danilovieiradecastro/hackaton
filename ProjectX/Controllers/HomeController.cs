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
                //var value = ReturnQuantidadeRoundAvg(23.6666m);

                //var value2 = ReturnBelezaRoundAvg(89.5675m);

                //var fileName = "Images/" + value + "_" + value2 + ".png" ;

                var fileName = "Images/5_bonita.png";

                placesViewModel = context.LocalSets.Select(i => new PlacesViewModel() 
                                                                        {
                                                                            Id = i.Id,
                                                                            Name = i.Nome,
                                                                            Lat = i.Latitude.ToString(),
                                                                            Lon = i.Longitude.ToString(),
                                                                            Img = fileName
                                                                        }).ToList();
                //foreach (var place in placesViewModel)
                //{
                //    var belezaAvg = context.PostSets.Where(i => i.Data > DateTime.Now.AddMinutes(-90) && i.Votos < 3).Average(i => i.Beleza);
                   
                //}


            }

            return View(placesViewModel);
        }

        public int ReturnQuantidadeRoundAvg(decimal avg)
        {
            int value = 1;

            if (avg < 20)
                value = 1;
            else if (avg > 20 && avg < 40)
                value = 2;
            else if (avg > 40 && avg < 60)
                value = 3;
            else if (avg > 60 && avg < 80)
                value = 4;
            else
                value = 5;

            return value;
        }

        public string ReturnBelezaRoundAvg(decimal avg)
        {
            string value = "";

            if (avg < 20)
                value = "capeta";
            else if (avg > 20 && avg < 40)
                value = "pegoBebado";
            else if (avg > 40 && avg < 60)
                value = "pegavel";
            else if (avg > 60 && avg < 80)
                value = "bonita";
            else
                value = "princesa";

            return value;
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