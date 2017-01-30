using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practica1.Models
{
    public class Estados
    {
        [Key]
        public int estadoID { get; set; }
        public string nombreEstado { get; set; }

        public virtual ICollection<Municipios> municipios { get; set; }
    }
}