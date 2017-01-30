using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica1.Models
{
    public class Producto
    {
        private int id;

        public Producto(int id)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;

        }
        public Producto()
        { }
        public int productoID { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
    }
}