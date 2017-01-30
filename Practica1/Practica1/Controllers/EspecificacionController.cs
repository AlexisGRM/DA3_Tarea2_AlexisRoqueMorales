using Practica1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1.Controllers
{
    public class EspecificacionController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Especificaciones
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getEspecificaciones(int? id)
        {
            if (id == null)
            {
                var esp = db.especificacion.ToList();
                return Json(esp, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var esp = db.especificacion.Find(id);
                return Json(esp, JsonRequestBehavior.AllowGet);
            }

        }
    }
}