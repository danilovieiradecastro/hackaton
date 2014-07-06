using ProjectX.Business.GooglePlacesAPI;
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
                model.BaladaSelecionada = db.LocalSets.Where(x => x.Id == id).FirstOrDefault();
            }

            GooglePlacesAPI api = new GooglePlacesAPI();
            var placeDetail = api.GetPlaceDetail(model.BaladaSelecionada.GoogleReference);

            model.Site = placeDetail.result.website;
            model.Telefone = placeDetail.result.formatted_phone_number;
            model.Endereco = placeDetail.result.formatted_address;
            model.Rating = placeDetail.result.rating;
            model.Name = placeDetail.result.name;


            return PartialView("/Views/DescribePlace/Index.cshtml", model);
        }
	}
}