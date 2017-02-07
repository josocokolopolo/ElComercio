using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parte2.Entities;
using Parte2.Datos;

namespace Parte2.Logica
{
    public class SucursalLogica
    {
        public bool CrearSucursal(int banco, string nombre, string direccion, DateTime fechaRegistro)
        {
            if (banco >= 0 && !string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(direccion) && fechaRegistro != null)
            {
                Sucursal sucursal = new Sucursal(0, banco, nombre, direccion, fechaRegistro);
                SucursalDatos sucursalDatos = new SucursalDatos();
                return sucursalDatos.Crear(sucursal);
            }
            else
            { return false; }
        }
        public List<Sucursal> ListarTodos()
        {
            SucursalDatos sucursalDatos = new SucursalDatos();
            return sucursalDatos.ListarTodos();
        }
        public Sucursal ObtenerPorId(int id)
        {
            if (id >= 0)
            {
                SucursalDatos sucursalDatos = new SucursalDatos();
                return sucursalDatos.ObtenerPorId(id);
            }
            else
            { return null; }
        }
        public bool ActualizarSucursal(int id, int banco, string nombre, string direccion, DateTime fechaRegistro)
        {
            if (id >= 0 && banco >= 0 && !string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(direccion) && fechaRegistro != null)
            {
                Sucursal sucursal = new Sucursal(id, banco, nombre, direccion, fechaRegistro);
                SucursalDatos sucursalDatos = new SucursalDatos();
                return sucursalDatos.Actualizar(sucursal);
            }
            else
            { return false; }
        }
        public bool Eliminar(int id)
        {
            if (id >= 0)
            {
                SucursalDatos sucursalDatos = new SucursalDatos();
                Sucursal sucursal = sucursalDatos.ObtenerPorId(id);
                if (sucursal != null)
                {
                    return sucursalDatos.Eliminar(sucursal);
                }
                else
                { return false; }
            }
            else
            { return false; }
        }
    }
}
