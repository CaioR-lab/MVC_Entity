using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.Context
{
    public class JaquetaContext : DbContext
    {
        public DbSet<Jaqueta> Jaqueta { get; set; }
        //public DbSet Calçados { get; set; }

        public JaquetaContext() : base("JaquetaConnection")
        {

        }
    }
}