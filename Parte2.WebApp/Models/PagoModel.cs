using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parte2.Entities;

namespace Parte2.WebApp.Models
{
    public class PagoModel
    {
        public int id { get; set; }
        public int sucursal { get; set; }
        public decimal monto { get; set; }
        public DateTime? fechaPago { get; set; }

        public static PagoModel ParseSingle(Pago pago)
        {
            PagoModel PagoModel = new PagoModel();
            PagoModel.id = pago.id;
            PagoModel.sucursal = pago.sucursal;
            PagoModel.monto = pago.monto;
            PagoModel.fechaPago = pago.fechaPago;
            return PagoModel;
        }

        public static List<PagoModel> ParseMultiple(List<Pago> pagoList)
        {
            List<PagoModel> pagoModelList = new List<PagoModel>();

            foreach (var pago in pagoList)
            {
                pagoModelList.Add(ParseSingle(pago));
            }

            return pagoModelList;
        }
    }
}