using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Jaqueta : BaseModel
    {
        public string Tecido { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

    }
}