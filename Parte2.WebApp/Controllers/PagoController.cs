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
    public class PagoController : Controller
    {
        // GET: Pago
        public ActionResult Index()
        {
            PagoLogica pagoLogica = new PagoLogica();

            return View(PagoModel.ParseMultiple(pagoLogica.ListarTodos()));
        }

        public ActionResult Details(int id = 0)
        {
            PagoLogica pagoLogica = new PagoLogica();

            return View(PagoModel.ParseSingle(pagoLogica.ObtenerPorId(id)));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PagoModel pago)
        {
            PagoLogica pagoLogica = new PagoLogica();
            if (pagoLogica.CrearPago(pago.sucursal, pago.monto, pago.fechaPago ?? new DateTime()))
                return View(pago);
            else
                return RedirectToAction("Create", "Pago");
        }

        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(PagoModel pago)
        {
            PagoLogica pagoLogica = new PagoLogica();
            if (pagoLogica.ActualizarPago(pago.id, pago.sucursal, pago.monto, pago.fechaPago ?? new DateTime()))
                return View(Pago);
            else
                return RedirectToAction("Update", "Pago");
        }

        [HttpPost]
        public ActionResult Delete(int pagoId)
        {
            PagoLogica pagoLogica = new PagoLogica();
            if (pagoLogica.Eliminar(pagoId))
                return RedirectToAction("Index", "Pago");
            else
                return RedirectToAction("Details", "Pago", new { id = pagoId });
        }
    }
}