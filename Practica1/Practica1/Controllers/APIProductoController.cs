using Practica1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1.Controllers
{
    public class ProductoController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Producto
        //[AllowCrossSiteJsonAtribute]
        public JsonResult getJsonList()
        {
            var productos = db.producto.ToList();
            return Json(productos, JsonRequestBehavior.AllowGet);
        }

        public JsonResult createProducto(Producto producto)
        {
            var respuesta = new { funciono = false };

            try
            {
                db.producto.Add(producto);
                int registrosModificados = db.SaveChanges();

                //Se logró ejecutar el query, pero, se hicieron cambios?
                if (registrosModificados > 0)
                {
                    respuesta = new { funciono = true };
                }
            }
            catch { }


            return Json(respuesta);
        }
        public JsonResult editarProducto(int id)
        {
            var ProductoEditado = db.producto.Find(id);
            var result = new { id = ProductoEditado.productoID, nombre = ProductoEditado.nombre, precio = ProductoEditado.precio };
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        //[ActionName("editarProducto")]
        public JsonResult editar(Producto producto)
        {
            //Producto modificar = db.productos.Find(id);
            //var resultado = db.Entry(modificar).State = EntityState.Modified;

            //db.SaveChanges();
            var resultado = db.Entry(producto).State = EntityState.Modified;
            db.SaveChanges();

            return Json(resultado, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public JsonResult eliminarProducto(int id)
        {
            Producto eliminar = db.producto.Find(id);
            var resultado = db.producto.Remove(eliminar);
            db.SaveChanges();
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public class AllowCrossSiteJsonAttribute : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Origin", "*");
                base.OnActionExecuting(filterContext);
            }
        }
    }
}