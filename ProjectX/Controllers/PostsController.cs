using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectX.Models;
using System.IO;
using System.Data.Entity.Validation;

namespace ProjectX.Controllers
{
    public class PostsController : Controller
    {
        //
        // GET: /Posts/
        public ActionResult Index()
        {
            ViewModelPost model = new ViewModelPost();
            using (var db = new EsquentaContainerContext())
            {
                model.ListaBaladas = db.LocalSets.ToArray();
            }
            return View(model);
        }

        public ActionResult RetornarViewAjax()
        {
            ViewModelPost model = new ViewModelPost();
            using (var db = new EsquentaContainerContext())
            {
                model.ListaBaladas = db.LocalSets.ToArray();
            }
            model.isBaladaSelecionada = false;
            return PartialView("/Views/Posts/Index.cshtml", model);
        }

        public ActionResult RetornarViewAjaxLocalSelecionado(string Id)
        {
            ViewModelPost model = new ViewModelPost();
            int id = Convert.ToInt32(Id);
            using (var db = new EsquentaContainerContext())
            {
                model.ListaBaladas = db.LocalSets.Where(x => x.Id == id).ToList();
            }
            model.isBaladaSelecionada = true;
            return PartialView("/Views/Posts/Index.cshtml", model);
        }

        [HttpGet]
        public ActionResult CriarPost()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CriarPost(FormCollection model)
        {
            var result = Request.Files["hdnImage"];
            MemoryStream memoryStream = new MemoryStream();
            Stream st = result != null ? result.InputStream : null;
            if(st != null)
                st.CopyTo(memoryStream);

            var selec = Request.Form["hdnLocal"];
            string anonimo = Request.Form["hdnAnonimo"];
            string desc = Request.Form["hdnDescricao"];
            string qtd = Request.Form["hdnQtd"];
            string qld = Request.Form["hdnQld"];

            using (var db = new EsquentaContainerContext())
            {


                var user = db.UserSets.Where(ae => ae.Nome == User.Identity.Name).First();
                db.PostSets.Add(new PostSet
                {
                    IsAnonimo = Convert.ToBoolean(anonimo),
                    Beleza = Convert.ToInt32(qld),
                    Data = System.DateTime.Now,
                    Descricao = desc,
                    Quantidade = Convert.ToInt32(qtd),
                    Votos = 0,
                    User_id = user.Id,
                    UserSet = user,
                    Foto = memoryStream.ToArray(),
                    Local_Id = Convert.ToInt32(selec)
                });
                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
            }
            return RedirectToAction("Index","Home");
        }

    }
}