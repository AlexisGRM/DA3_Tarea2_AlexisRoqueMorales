using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica1.Models
{
    public class Municipios
    {
        [Key]
        public int municipioID { get; set; }
        public string nombreMunicipio { get; set; }

        public int estadoID { get; set; }

        virtual public Estados estado { get; set; }
    }
}