using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parte2.Entities;

namespace Parte2.Datos
{
    public class SucursalDatos
    {
        //string connectionString = @"Server=.\sqlexpress;Database=banking;Trusted_Connection=True;";
        public bool Crear(Sucursal sucursalEntidad)
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //using (var conn = new SqlConnection(connectionString))
            //using (var command = new SqlCommand("SP_CrearSucursal", conn)
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

        public List<Sucursal> ListarTodos()
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "SP_ListarSucursales";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Connection = sqlConnection1;

            //sqlConnection1.Open();

            //reader = cmd.ExecuteReader();
            // Se leen los datos del objeto reader

            //sqlConnection1.Close();

            return new List<Sucursal>();
        }

        public Sucursal ObtenerPorId(int id)
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "SP_ListarSucursales"; //uso el mismo procedimiento pero se pasa el id
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            //cmd.Connection = sqlConnection1;

            //sqlConnection1.Open();

            //reader = cmd.ExecuteReader();
            // Se leen los datos del objeto reader

            //sqlConnection1.Close();

            return new Sucursal();
        }

        public bool Actualizar(Sucursal sucursalEntidad)
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "SP_ActualizarSucursal";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Id", SqlDbType.Int).Value = sucursalEntidad.id;
            //cmd.Parameters.Add("@Banco", SqlDbType.Int).Value = sucursalEntidad.banco;
            //cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = sucursalEntidad.nombre;
            //cmd.Parameters.Add("@Direccion", SqlDbType.Int).Value = sucursalEntidad.direccion;
            //cmd.Parameters.Add("@FechaRegistro", SqlDbType.DateTime).Value = sucursalEntidad.fechaRegistro;
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

        public bool Eliminar(Sucursal sucursalEntidad)
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "SP_EliminarSucursal";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Id", SqlDbType.Int).Value = sucursalEntidad.id;
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
