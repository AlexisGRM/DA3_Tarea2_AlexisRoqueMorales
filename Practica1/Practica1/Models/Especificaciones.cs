using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica1.Models
{
    public class Especificaciones
    {
        [Key]
        public int id { get; set; }
        public string modelo { get; set; }
        public string costo { get; set; }
        public string ram { get; set; }
        public string procesador { get; set; }
        public string hdd { get; set; }
        public string dimensiones { get; set; }
    }
}