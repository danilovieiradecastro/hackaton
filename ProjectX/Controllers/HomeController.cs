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
                var value = ReturnQuantidadeRoundAvg(23.6666m);

                var value2 = ReturnBelezaRoundAvg(89.5675m);

                var fileName = "Images/" + value + "_" + value2 + ".png" ;

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
            int value = (int)Math.Truncate(avg);
            Dictionary<int, int> avgs = new Dictionary<int, int>();
            avgs.Add(1, Math.Abs(value - 20));
            avgs.Add(2, Math.Abs(value - 40));
            avgs.Add(3, Math.Abs(value - 60));
            avgs.Add(4, Math.Abs(value - 80));
            avgs.Add(5, Math.Abs(value - 100));

            var min = avgs.Min(i => i.Value);

            return avgs.Where(i => i.Value == min).Select(i => i.Key).First();
        }

        public string ReturnBelezaRoundAvg(decimal avg)
        {
            int value = (int)Math.Truncate(avg);
            Dictionary<string, int> avgs = new Dictionary<string, int>();
            avgs.Add("capeta", Math.Abs(value - 20));
            avgs.Add("pegoBebado", Math.Abs(value - 40));
            avgs.Add("pegavel", Math.Abs(value - 60));
            avgs.Add("bonita", Math.Abs(value - 80));
            avgs.Add("princesa", Math.Abs(value - 100));

            var min = avgs.Min(i => i.Value);

            return avgs.Where(i => i.Value == min).Select(i => i.Key).First();
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