﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parte2.Entities;

namespace Parte2.Datos
{
    public class PagoDatos
    {
        //string connectionString = @"Server=.\sqlexpress;Database=banking;Trusted_Connection=True;";
        public bool Crear(Pago pagoEntidad)
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //using (var conn = new SqlConnection(connectionString))
            //using (var command = new SqlCommand("SP_CrearPago", conn)
            //{
            //    CommandType = CommandType.StoredProcedure
            //})
            //{
            //    conn.Open();
            //    command.ExecuteNonQuery();
            //si se genero el id correctamente
            return true;
            //de lo contrario
            //return false;
            //}
        }

        public List<Pago> ListarTodos()
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "SP_ListarPagos";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Connection = sqlConnection1;

            //sqlConnection1.Open();

            //reader = cmd.ExecuteReader();
            // Se leen los datos del objeto reader

            //sqlConnection1.Close();

            return new List<Pago>();
        }

        public Pago ObtenerPorId(int id)
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "SP_ListarPagos"; //uso el mismo procedimiento pero se pasa el id
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            //cmd.Connection = sqlConnection1;

            //sqlConnection1.Open();

            //reader = cmd.ExecuteReader();
            // Se leen los datos del objeto reader

            //sqlConnection1.Close();

            return new Pago();
        }

        public bool Actualizar(Pago pagoEntidad)
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "SP_ActualizarPago";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Id", SqlDbType.Int).Value = pagoEntidad.id;
            //cmd.Parameters.Add("@Sucursal", SqlDbType.Int).Value = pagoEntidad.sucursal;
            //cmd.Parameters.Add("@Monto", SqlDbType.Decimal).Value = pagoEntidad.monto;
            //cmd.Parameters.Add("@fechaPago", SqlDbType.DateTime).Value = pagoEntidad.fechaPago;
            //cmd.Connection = sqlConnection1;

            //sqlConnection1.Open();

            //reader = cmd.ExecuteReader();
            // Se leen los datos del objeto reader

            //sqlConnection1.Close();

            //si se actualizo
            return true;
            //en caso contrario
            //return false;
        }

        public bool Eliminar(Pago pagoEntidad)
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "SP_EliminarPago";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Id", SqlDbType.Int).Value = pagoEntidad.id;
            //cmd.Connection = sqlConnection1;

            //sqlConnection1.Open();

            //cmd.ExecuteNonQuery();

            //sqlConnection1.Close();

            //si se elimino
            return true;
            //en caso contrario
            //return false;
        }
    }
}
