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

                var fileName = "Images/1_pegoBebado.png ";

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