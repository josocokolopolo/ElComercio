using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parte2.WebApp.Models;
using Parte2.Entities;
using Parte2.Logica;

namespace Parte2.WebApp.Controllers
{
    public class OrdenDePagoController : Controller
    {
        // GET: OrdenDePago
        public ActionResult Index()
        {
            OrdenDePagoLogica ordenDePagoLogica = new OrdenDePagoLogica();

            return View(OrdenDePagoModel.ParseMultiple(ordenDePagoLogica.ListarTodos()));
        }

        public ActionResult Details(int id = 0)
        {
            OrdenDePagoLogica ordenDePagoLogica = new OrdenDePagoLogica();

            return View(OrdenDePagoModel.ParseSingle(ordenDePagoLogica.ObtenerPorId(id)));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(OrdenDePagoModel ordenDePago)
        {
            OrdenDePagoLogica ordenDePagoLogica = new OrdenDePagoLogica();
            if (ordenDePagoLogica.CrearOrdenDePago(ordenDePago.banco, ordenDePago.monto, ordenDePago.moneda, ordenDePago.estado, ordenDePago.fechaPago))
                return View(ordenDePago);
            else
                return RedirectToAction("Create", "OrdenDePago");
        }

        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(OrdenDePagoModel ordenDePago)
        {
            OrdenDePagoLogica ordenDePagoLogica = new OrdenDePagoLogica();
            if (ordenDePagoLogica.ActualizarOrdenDePago(ordenDePago.id, ordenDePago.banco, ordenDePago.monto, ordenDePago.moneda, ordenDePago.estado, ordenDePago.fechaPago))
                return View(ordenDePago);
            else
                return RedirectToAction("Update", "OrdenDePago");
        }

        [HttpPost]
        public ActionResult Delete(int ordenDePagoId)
        {
            OrdenDePagoLogica ordenDePagoLogica = new OrdenDePagoLogica();
            if (ordenDePagoLogica.Eliminar(ordenDePagoId))
                return RedirectToAction("Index", "OrdenDePago");
            else
                return RedirectToAction("Details", "OrdenDePago", new { id = ordenDePagoId });
        }
    }
}