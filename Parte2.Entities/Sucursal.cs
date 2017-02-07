using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte2.Entities
{
    public class Sucursal
    {
        public int id { get; set; }
        public int banco { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public DateTime fechaRegistro { get; set; }

        public Sucursal()
        {
            this.id = 0;
            this.banco = 0;
            this.nombre = "";
            this.direccion = "";
            this.fechaRegistro = new DateTime();
        }

        public Sucursal(int id, int banco, string nombre, string direccion, DateTime fechaRegistro)
        {
            this.id = id;
            this.banco = banco;
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaRegistro = fechaRegistro;
        }
    }
}
