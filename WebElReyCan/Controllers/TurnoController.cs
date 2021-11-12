using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebElReyCan.Models;
using WebElReyCan.Admin;
using System.Data.Entity;
using WebElReyCan.Filters;

namespace WebElReyCan.Controllers
{
    [MyFilter]
    public class TurnoController : Controller
    {
        // GET: Turno
        public ActionResult Index(string nombreMascota)
        {
            int nomb = String.IsNullOrEmpty(nombreMascota) ? 0 : 1;
            switch (nomb)
            {
                case 0:
                    return View(AdmTurno.Listar());
                case 1:
                    return View(AdmTurno.ListarTurno(nombreMascota));
                default:
                    return View();
            }
        }

        public ActionResult Create()
        {
            Turno turno = new Turno();
            return View("Create", turno);
        }

        [HttpPost]
        public ActionResult Create(Turno turno)
        {
            if (ModelState.IsValid)
            {
                AdmTurno.Insertar(turno);
                return RedirectToAction("Index");
            }
            return View("Create", turno);

        }

        public ActionResult Details(int id)
        {
            Turno turno = AdmTurno.TraerPorID(id);
            if (turno != null)
            {
                return View("Details", turno);
            }
            else
            {
                return HttpNotFound();

            }
        }

        public ActionResult Delete(int id)
        {
            Turno turno = AdmTurno.TraerPorID(id);
            if (turno != null)
            {
                return View("Delete", turno);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Turno turno = AdmTurno.TraerPorID(id);
            AdmTurno.Eliminar(turno);
            return RedirectToAction("Index");
        }

        public ActionResult DetailByTurno(string nombreMascota)
        {
            if (nombreMascota == "Todas")
            {
                return RedirectToAction("Index");
            }
            return View("Index", AdmTurno.ListarTurno(nombreMascota));
        }

        public ActionResult Edit(int id)
        {
            Turno turno = AdmTurno.TraerPorID(id);
            if (turno != null)
            {
                return View("Edit");
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        public ActionResult Edit(Turno turno)
        {
            AdmTurno.Editar(turno);
            return RedirectToAction("Index");
        }
    }
}