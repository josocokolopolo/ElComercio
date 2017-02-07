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
    public class SucursalController : Controller
    {
        // GET: Sucursal
        public ActionResult Index()
        {
            SucursalLogica sucursalLogica = new SucursalLogica();

            return View(SucursalModel.ParseMultiple(sucursalLogica.ListarTodos()));
        }

        public ActionResult Details(int id = 0)
        {
            SucursalLogica sucursalLogica = new SucursalLogica();

            return View(SucursalModel.ParseSingle(sucursalLogica.ObtenerPorId(id)));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(SucursalModel sucursal)
        {
            SucursalLogica sucursalLogica = new SucursalLogica();
            if (sucursalLogica.CrearSucursal(sucursal.banco, sucursal.nombre, sucursal.direccion, sucursal.fechaRegistro))
                return View(sucursal);
            else
                return RedirectToAction("Create", "Sucursal");
        }

        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(SucursalModel sucursal)
        {
            SucursalLogica sucursalLogica = new SucursalLogica();
            if (sucursalLogica.ActualizarSucursal(sucursal.id, sucursal.banco, sucursal.nombre, sucursal.direccion, sucursal.fechaRegistro))
                return View(sucursal);
            else
                return RedirectToAction("Update", "Sucursal");
        }

        [HttpPost]
        public ActionResult Delete(int sucursalId)
        {
            SucursalLogica sucursalLogica = new SucursalLogica();
            if (sucursalLogica.Eliminar(sucursalId))
                return RedirectToAction("Index", "Sucursal");
            else
                return RedirectToAction("Details", "Sucursal", new { id = sucursalId });
        }
    }
}