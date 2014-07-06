using ProjectX.Helpers;
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
                                                                            Id = i.Id,
                                                                            Name = i.Nome,
                                                                            Lat = i.Latitude.ToString(),
                                                                            Lon = i.Longitude.ToString(),                                                                            
                                                                        }).ToList();
                foreach (var place in placesViewModel)
                {
                    var posts = context.PostSets.AsEnumerable().Where(i => i.Data > DateTime.Now.AddMinutes(-90) && i.Votos < 3 && i.Local_Id == place.Id);

                    double belezaAvg = 20;

                    if (posts.Count() > 0)
                    {
                        belezaAvg = posts.Average(i => i.Beleza);
                    }
 
                    double quantidadeAvg = 20;

                    if (posts.Count() > 0)
                    {
                        quantidadeAvg = posts.Average(i => i.Quantidade);
                    }

                    place.Img = @"/Images/"+ ClassificationHelper.ReturnQuantidadeRoundAvg((decimal)quantidadeAvg) + "_" +
                                ClassificationHelper.ReturnBelezaRoundAvg((decimal)belezaAvg) + ".png";

                }
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

        public ActionResult CriarPost()
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