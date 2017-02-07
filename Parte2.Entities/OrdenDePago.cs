using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte2.Entities
{
    public class OrdenDePago
    {
        public int id { get; set; }
        public int banco { get; set; }
        public decimal monto { get; set; }
        public int moneda { get; set; }
        public int estado { get; set; }
        public DateTime? fechaPago { get; set; }

        public OrdenDePago()
        {
            this.id = 0;
            this.banco = 0;
            this.monto = 0;
            this.moneda = 1;
            this.fechaPago = null;
        }

        public OrdenDePago(int id, int banco, decimal monto, int moneda, int estado, DateTime? fechaPago)
        {
            this.id = id;
            this.banco = banco;
            this.monto = monto;
            this.moneda = moneda;
            this.fechaPago = fechaPago;
        }
    }
}
