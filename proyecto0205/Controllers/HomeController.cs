using proyecto0205.Models;
using proyecto0205.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyecto0205.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "CArlos Ayuda.";

            var peliculaService = new PeliculasService();
            //var model = peliculaService.ObtenerPelicula();
            List<Pelicula> modelos = peliculaService.ObtenerVariasPeliculas();
           // var modelos = peliculaService.ObtenerVariasPeliculas();

            return View(modelos);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}