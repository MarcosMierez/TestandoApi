using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using TesteApi.Repositorio;

namespace TesteApi.Controllers
{
    public class HomeController : Controller
    {
       private NoticiaCRUD ntc=new NoticiaCRUD();
        public ActionResult Index()
        {       
            return View();
        }

        public ActionResult TodasNoticias()
        {
            return View(ntc.ListarNoticias());
        }

        public ActionResult NoticiaDetalhe(string id)
        {
            return View();
        }
    }
}