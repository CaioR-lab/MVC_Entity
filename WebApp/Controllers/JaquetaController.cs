using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using WebApp.Repository;

namespace WebApp.Controllers
{
    public class JaquetaController : Controller
    {
        JaquetaRepository repository = new JaquetaRepository();
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Jaqueta model)
        {
            repository.Create(model);
            ModelState.Clear();
            return View();
        }
        public ActionResult Details(int id)
        {
            return View(repository.Read(id));
        }



        public ActionResult Edit(int id)
        {

            return View(repository.Read(id));
        }

        [HttpPost]
        public ActionResult Edit(Jaqueta model)
        {
            repository.Update(model);
            return RedirectToAction("List");
        }
        public ActionResult Delete(int id)
        {

            return View(repository.Read(id));
        }

        [HttpPost]
        public ActionResult Delete(Jaqueta model)
        {
            int id = model.Id;
            repository.Delete(id);
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            return View(repository.Read());
        }
            
    }
}
