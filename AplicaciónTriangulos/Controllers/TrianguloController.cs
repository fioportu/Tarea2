using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TrianguloApp.Models;

namespace TrianguloApp.Controllers
{
    public class TrianguloController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(double ladoA, double ladoB, double ladoC)
        {
            var triangulo = new Triangulo
            {
                LadoA = ladoA,
                LadoB = ladoB,
                LadoC = ladoC
            };

            if (!triangulo.EsTriangulo())
            {
                ViewBag.Mensaje = "Los lados no forman un triángulo válido.";
            }
            else
            {
                var (alfa, beta, gamma) = triangulo.CalcularAngulos();
                ViewBag.Alfa = alfa;
                ViewBag.Beta = beta;
                ViewBag.Gamma = gamma;

                ViewBag.Tipo = triangulo.Tipo();
                ViewBag.Perimetro = triangulo.Perimetro();
                ViewBag.Semiperimetro = triangulo.Semiperimetro();
                ViewBag.Area = triangulo.Area();
            }

            return View();
        }
    }
}