using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parte2.Entities;
using Parte2.Datos;

namespace Parte2.Logica
{
    public class BancoLogica
    {
        public bool CrearBanco(string nombre, string direccion, DateTime fechaRegistro)
        {
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(direccion) && fechaRegistro != null)
            {
                Banco banco = new Banco(0, nombre, direccion, fechaRegistro);
                BancoDatos bancoDatos = new BancoDatos();
                return bancoDatos.Crear(banco);
            }
            else
            { return false; }
        }
        public List<Banco> ListarTodos()
        {
            BancoDatos bancoDatos = new BancoDatos();
            return bancoDatos.ListarTodos();
        }
        public Banco ObtenerPorId(int id)
        {
            if (id >= 0)
            {
                BancoDatos bancoDatos = new BancoDatos();
                return bancoDatos.ObtenerPorId(id);
            }
            else
            { return null; }
        }
        public bool ActualizarBanco(int id, string nombre, string direccion, DateTime fechaRegistro)
        {
            if (id >= 0 &&!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(direccion) && fechaRegistro != null)
            {
                Banco banco = new Banco(id, nombre, direccion, fechaRegistro);
                BancoDatos bancoDatos = new BancoDatos();
                return bancoDatos.Actualizar(banco);
            }
            else
            { return false; }
        }
        public bool Eliminar(int id)
        {
            if (id >= 0)
            {
                BancoDatos bancoDatos = new BancoDatos();
                Banco banco = bancoDatos.ObtenerPorId(id);
                if (banco != null)
                {
                    return bancoDatos.Eliminar(banco);
                }
                else
                { return false; }
            }
            else
            { return false; }
        }
    }
}
