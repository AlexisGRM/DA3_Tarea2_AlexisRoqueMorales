using Practica1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1.Controllers
{
    public class EstadoController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Estado
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getJsonList()
        {

            var estados = from est in db.estado
                          select new { estadoID = est.estadoID, estado = est.nombreEstado };
            return Json(estados, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getMunicipios(int estado)
        {

            var municipios = from mun in db.municipio
                             where mun.estadoID == estado
                             select new { municipioID = mun.municipioID, municipio = mun.nombreMunicipio };
            return Json(municipios, JsonRequestBehavior.AllowGet);
        }
    }
}