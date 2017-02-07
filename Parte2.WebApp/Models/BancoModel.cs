using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parte2.Entities;

namespace Parte2.WebApp.Models
{
    public class BancoModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public DateTime fechaRegistro { get; set; }

        public static BancoModel ParseSingle(Banco banco)
        {
            BancoModel bancoModel = new BancoModel();
            bancoModel.id = banco.id;
            bancoModel.nombre = banco.nombre;
            bancoModel.direccion = banco.direccion;
            bancoModel.fechaRegistro = banco.fechaRegistro;
            return bancoModel;
        }

        public static List<BancoModel> ParseMultiple(List<Banco> bancoList)
        {
            List<BancoModel> bancoModelList = new List<BancoModel>();

            foreach (var banco in bancoList)
            {
                bancoModelList.Add(ParseSingle(banco));
            }

            return bancoModelList;
        }
    }
}