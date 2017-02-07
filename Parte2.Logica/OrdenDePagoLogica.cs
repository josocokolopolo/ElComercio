using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parte2.Entities;
using Parte2.Datos;

namespace Parte2.Logica
{
    public class OrdenDePagoLogica
    {
        public bool CrearOrdenDePago(int banco, decimal monto, int moneda, int estado, DateTime fechaPago)
        {
            if (banco >=0 && monto > 0 && moneda > 0 && estado > 0 && fechaPago != null)
            {
                OrdenDePago ordenDePago = new OrdenDePago(0, banco, monto, moneda, estado, fechaPago);
                OrdenDePagoDatos ordenDePagoDatos = new OrdenDePagoDatos();
                return ordenDePagoDatos.Crear(ordenDePago);
            }
            else
            { return false; }
        }
        public List<OrdenDePago> ListarTodos()
        {
            OrdenDePagoDatos ordenDePagoDatos = new OrdenDePagoDatos();
            return ordenDePagoDatos.ListarTodos();
        }
        public OrdenDePago ObtenerPorId(int id)
        {
            if (id >= 0)
            {
                OrdenDePagoDatos ordenDePagoDatos = new OrdenDePagoDatos();
                return ordenDePagoDatos.ObtenerPorId(id);
            }
            else
            { return null; }
        }
        public bool ActualizarOrdenDePago(int id, int banco, decimal monto, int moneda, int estado, DateTime fechaPago)
        {
            if (id >=0 && banco >= 0 && monto > 0 && moneda > 0 && estado > 0 && fechaPago != null)
            {
                OrdenDePago ordenDePago = new OrdenDePago(id, banco, monto, moneda, estado, fechaPago);
                OrdenDePagoDatos ordenDePagoDatos = new OrdenDePagoDatos();
                return ordenDePagoDatos.Actualizar(ordenDePago);
            }
            else
            { return false; }
        }
        public bool Eliminar(int id)
        {
            if (id >= 0)
            {
                OrdenDePagoDatos ordenDePagoDatos = new OrdenDePagoDatos();
                OrdenDePago ordenDePago = ordenDePagoDatos.ObtenerPorId(id);
                if (ordenDePago != null)
                {
                    return ordenDePagoDatos.Eliminar(ordenDePago);
                }
                else
                { return false; }
            }
            else
            { return false; }
        }
    }
}
