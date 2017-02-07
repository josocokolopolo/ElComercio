using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte2.Entities
{
    public class Banco
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public DateTime fechaRegistro { get; set; }

        public Banco() {
            this.id = 0;
            this.nombre = "";
            this.direccion = "";
            this.fechaRegistro = new DateTime();
        }

        public Banco(int id, string nombre,string direccion, DateTime fechaRegistro)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaRegistro = fechaRegistro;
        }
    }
}
