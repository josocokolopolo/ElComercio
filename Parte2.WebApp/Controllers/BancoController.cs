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
    public class BancoController : Controller
    {
        // GET: Banco
        public ActionResult Index()
        {
            BancoLogica bancoLogica = new BancoLogica();

            return View(BancoModel.ParseMultiple(bancoLogica.ListarTodos()));
        }

        public ActionResult Details(int id = 0)
        {
            BancoLogica bancoLogica = new BancoLogica();

            return View(BancoModel.ParseSingle(bancoLogica.ObtenerPorId(id)));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BancoModel banco)
        {
            BancoLogica bancoLogica = new BancoLogica();
            if (bancoLogica.CrearBanco(banco.nombre, banco.direccion, banco.fechaRegistro))
                return View(banco);
            else
                return RedirectToAction("Create", "Banco");
        }

        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(BancoModel banco)
        {
            BancoLogica bancoLogica = new BancoLogica();
            if (bancoLogica.ActualizarBanco(banco.id, banco.nombre, banco.direccion, banco.fechaRegistro))
                return View(banco);
            else
                return RedirectToAction("Update", "Banco");
        }

        [HttpPost]
        public ActionResult Delete(int bancoId)
        {
            BancoLogica bancoLogica = new BancoLogica();
            if (bancoLogica.Eliminar(bancoId))
                return RedirectToAction("Index", "Banco");
            else
                return RedirectToAction("Details", "Banco", new { id = bancoId });
        }
    }
}