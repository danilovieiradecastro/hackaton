using ProjectX.Business.GooglePlacesAPI;
using ProjectX.Helpers;
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
                var time =  DateTime.Now.AddMinutes(-90);

                model.Posts = db.PostSets.Include("UserSet").AsEnumerable()
                                         .Where(i => i.Data > time && i.Local_Id == id)
                                         .Select(i => new ViewModelPostDetail()
                                                        {
                                                            Id = i.Id,
                                                            Descricao = i.Descricao,
                                                            Data = i.Data,
                                                            IsAnonimo = i.IsAnonimo,
                                                            UserName = i.UserSet.Nome,
                                                            ClassificationImg = ClassificationHelper.ReturnQuantidadeRoundAvg((decimal)i.Beleza).ToString() + "_" +
                                                                                ClassificationHelper.ReturnBelezaRoundAvg((decimal)i.Quantidade) + ".png",
                                                            Qualidade = i.Beleza,
                                                            Quantidade = i.Quantidade
                                                        }).ToList();
                model.Qualidade = 20;
                model.Quantidade = 20;

                if (model.Posts.Count > 0)
                {
                    model.Qualidade = ClassificationHelper.ReturnRoundAvg( ((decimal)model.Posts.Average(i => i.Qualidade)));
                    model.Quantidade = ClassificationHelper.ReturnRoundAvg( ((decimal)model.Posts.Average(i => i.Quantidade)));
                }
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