using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parte2.Entities;
using Parte2.Datos;

namespace Parte2.Logica
{
    public class PagoLogica
    {
        public bool CrearPago(int sucursal, decimal monto, DateTime fechaPago)
        {
            if (sucursal >= 0 && monto > 0 && fechaPago != null)
            {
                Pago pago = new Pago(0, sucursal, monto, fechaPago);
                PagoDatos pagoDatos = new PagoDatos();
                return pagoDatos.Crear(pago);
            }
            else
            { return false; }
        }
        public List<Pago> ListarTodos()
        {
            PagoDatos pagoDatos = new PagoDatos();
            return pagoDatos.ListarTodos();
        }
        public Pago ObtenerPorId(int id)
        {
            if (id >= 0)
            {
                PagoDatos pagoDatos = new PagoDatos();
                return pagoDatos.ObtenerPorId(id);
            }
            else
            { return null; }
        }
        public bool ActualizarPago(int id, int sucursal, decimal monto, DateTime fechaPago)
        {
            if (id >= 0 && sucursal >= 0 && monto > 0 && fechaPago != null)
            {
                Pago pago = new Pago(id, sucursal, monto, fechaPago);
                PagoDatos pagoDatos = new PagoDatos();
                return pagoDatos.Actualizar(pago);
            }
            else
            { return false; }
        }
        public bool Eliminar(int id)
        {
            if (id >= 0)
            {
                PagoDatos pagoDatos = new PagoDatos();
                Pago pago = pagoDatos.ObtenerPorId(id);
                if (pago != null)
                {
                    return pagoDatos.Eliminar(pago);
                }
                else
                { return false; }
            }
            else
            { return false; }
        }
    }
}
