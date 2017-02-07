using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parte2.Entities;

namespace Parte2.WebApp.Models
{
    public class OrdenDePagoModel
    {
        public int id { get; set; }
        public int banco { get; set; }
        public decimal monto { get; set; }
        public int moneda { get; set; }
        public int estado { get; set; }
        public DateTime? fechaPago { get; set; }

        public static OrdenDePagoModel ParseSingle(OrdenDePago ordenDePago)
        {
            OrdenDePagoModel ordenDePagoModel = new OrdenDePagoModel();
            ordenDePagoModel.id = ordenDePago.id;
            ordenDePagoModel.banco = ordenDePago.banco;
            ordenDePagoModel.monto = ordenDePago.monto;
            ordenDePagoModel.moneda = ordenDePago.moneda;
            ordenDePagoModel.estado = ordenDePago.estado;
            ordenDePagoModel.fechaPago = ordenDePago.fechaPago;
            return ordenDePagoModel;
        }

        public static List<OrdenDePagoModel> ParseMultiple(List<OrdenDePago> ordenDePagoList)
        {
            List<OrdenDePagoModel> ordenDePagoModelList = new List<OrdenDePagoModel>();

            foreach (var ordenDePago in ordenDePagoList)
            {
                ordenDePagoModelList.Add(ParseSingle(ordenDePago));
            }

            return ordenDePagoModelList;
        }
    }
}