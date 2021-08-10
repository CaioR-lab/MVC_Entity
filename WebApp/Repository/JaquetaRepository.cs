using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Context;
using WebApp.Models;

namespace WebApp.Repository
{
    public class JaquetaRepository
    {
        public void Create(Jaqueta model)
        {
            using (var context = new JaquetaContext())
            {
                context.Jaqueta.Add(model);
                context.SaveChanges();
            }
        }

        public Jaqueta Read (int id)
        {
            Jaqueta model = new Jaqueta();
            using (var context = new JaquetaContext())
            {
                model = context.Jaqueta.Find(id);
            }
            return model;
        }

        public List<Jaqueta> Read()
        {
            List<Jaqueta> lista = new List<Jaqueta>();
            using (var context = new JaquetaContext())
            {
                lista = context.Jaqueta.ToList();
            }
            return lista;
        }

        public void Update(Jaqueta model)
        {
            using (var context = new JaquetaContext())
            {
                context.Entry<Jaqueta>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Jaqueta model = new Jaqueta();

            using (var context = new JaquetaContext())
            {
                context.Entry<Jaqueta>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}