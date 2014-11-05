using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Utp.Models
{
   
    public class Ubigeo
    {
       
        public int ID { get; set; }
        public string CodDep { get; set; }
        public string CodProv { get; set; }
        public string CodDist { get; set; }
        public string Departamento { get; set;}
        public string Provincia { get; set; }
        public string Distrito { get; set; }

       
    }
}