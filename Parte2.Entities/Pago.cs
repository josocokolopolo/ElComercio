using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte2.Entities
{
    /*CLASE CREADA PORQUE SE CONSIDERA QUE UNA ORDEN DE PAGO PUEDE SER PAGADA EN VARIAS SUCURSALES DEL MISMO BANCO*/
    public class Pago
    {
        public int id { get; set; }
        public int sucursal { get; set; }
        public decimal monto { get; set; }
        public DateTime? fechaPago { get; set; }

        public Pago()
        {
            this.id = 0;
            this.sucursal = 0;
            this.monto = 0;
            this.fechaPago = null;
        }

        public Pago(int id, int sucursal, decimal monto, DateTime? fechaPago)
        {
            this.id = id;
            this.sucursal = sucursal;
            this.monto = monto;
            this.fechaPago = fechaPago;
        }
    }
}
