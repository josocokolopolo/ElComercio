using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parte2.Entities;

namespace Parte2.WebApp.Models
{
    public class SucursalModel
    {
        public int id { get; set; }
        public int banco { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public DateTime fechaRegistro { get; set; }

        public static SucursalModel ParseSingle(Sucursal sucursal)
        {
            SucursalModel sucursalModel = new SucursalModel();
            sucursalModel.id = sucursal.id;
            sucursalModel.nombre = sucursal.nombre;
            sucursalModel.direccion = sucursal.direccion;
            sucursalModel.fechaRegistro = sucursal.fechaRegistro;
            return sucursalModel;
        }

        public static List<SucursalModel> ParseMultiple(List<Sucursal> sucursalList)
        {
            List<SucursalModel> sucursalModelList = new List<SucursalModel>();

            foreach (var sucursal in sucursalList)
            {
                sucursalModelList.Add(ParseSingle(sucursal));
            }

            return sucursalModelList;
        }
    }
}