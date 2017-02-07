using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parte2.Entities;

namespace Parte2.Datos
{
    public class BancoDatos
    {
        //string connectionString = @"Server=.\sqlexpress;Database=banking;Trusted_Connection=True;";
        public bool Crear(Banco bancoEntidad)
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //using (var conn = new SqlConnection(connectionString))
            //using (var command = new SqlCommand("SP_CrearBanco", conn)
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

        public List<Banco> ListarTodos()
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "SP_ListarBancos";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Connection = sqlConnection1;

            //sqlConnection1.Open();

            //reader = cmd.ExecuteReader();
            // Se leen los datos del objeto reader

            //sqlConnection1.Close();

            return new List<Banco>();
        }

        public Banco ObtenerPorId(int id)
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "SP_ListarBancos"; //uso el mismo procedimiento pero se pasa el id
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            //cmd.Connection = sqlConnection1;

            //sqlConnection1.Open();

            //reader = cmd.ExecuteReader();
            // Se leen los datos del objeto reader

            //sqlConnection1.Close();

            return new Banco();
        }

        public bool Actualizar(Banco bancoEntidad)
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "SP_ActualizarBanco";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Id", SqlDbType.Int).Value = bancoEntidad.id;
            //cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = bancoEntidad.nombre;
            //cmd.Parameters.Add("@Direccion", SqlDbType.Int).Value = bancoEntidad.direccion;
            //cmd.Parameters.Add("@FechaRegistro", SqlDbType.DateTime).Value = bancoEntidad.fechaRegistro;
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

        public bool Eliminar(Banco bancoEntidad)
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "SP_EliminarBanco";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Id", SqlDbType.Int).Value = bancoEntidad.id;
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
