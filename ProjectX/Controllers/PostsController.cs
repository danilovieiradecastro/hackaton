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
            return PartialView("/Views/Posts/Index.cshtml");
        }
      [HttpGet]
      public ActionResult CriarPost()
        {
          return View();
        }
      [HttpPost]
      public ActionResult CriarPost(FormCollection model)
      {
        var result = Request.Files["staffImage"];
       MemoryStream memoryStream = new MemoryStream();
        Stream st = result.InputStream;
        st.CopyTo(memoryStream);
        var selec = model["ListaBar"];
        using (var db = new EsquentaContainerContext())
        {
          

          var user = db.UserSets.Where(ae => ae.Email == "c0r3ylnx@gmail.com" ).First();
          db.PostSets.Add(new PostSet
            {
              IsAnonimo = false,
              Beleza = 100,
              Data = System.DateTime.Now,
              Descricao = "teste de descricao",
              Quantidade = 100,
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
        return View();
      }



	}
}