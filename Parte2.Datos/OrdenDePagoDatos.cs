using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parte2.Entities;

namespace Parte2.Datos
{
    public class OrdenDePagoDatos
    {
        //string connectionString = @"Server=.\sqlexpress;Database=banking;Trusted_Connection=True;";
        public bool Crear(OrdenDePago ordenDePagoEntidad)
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //using (var conn = new SqlConnection(connectionString))
            //using (var command = new SqlCommand("SP_CrearOrdenDePago", conn)
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

        public List<OrdenDePago> ListarTodos()
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "SP_ListarOrdenDePagos";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Connection = sqlConnection1;

            //sqlConnection1.Open();

            //reader = cmd.ExecuteReader();
            // Se leen los datos del objeto reader

            //sqlConnection1.Close();

            return new List<OrdenDePago>();
        }

        public OrdenDePago ObtenerPorId(int id)
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "SP_ListarOrdenDePagos"; //uso el mismo procedimiento pero se pasa el id
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            //cmd.Connection = sqlConnection1;

            //sqlConnection1.Open();

            //reader = cmd.ExecuteReader();
            // Se leen los datos del objeto reader

            //sqlConnection1.Close();

            return new OrdenDePago();
        }

        public bool Actualizar(OrdenDePago ordenDePagoEntidad)
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "SP_ActualizarOrdenDePago";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Id", SqlDbType.Int).Value = ordenDePagoEntidad.id;
            //cmd.Parameters.Add("@Banco", SqlDbType.Int).Value = ordenDePagoEntidad.banco;
            //cmd.Parameters.Add("@Monto", SqlDbType.Decimal).Value = ordenDePagoEntidad.monto;
            //cmd.Parameters.Add("@Moneda", SqlDbType.Int).Value = ordenDePagoEntidad.moneda;
            //cmd.Parameters.Add("@Estado", SqlDbType.Int).Value = ordenDePagoEntidad.estado;
            //cmd.Parameters.Add("@fechaPago", SqlDbType.DateTime).Value = ordenDePagoEntidad.fechaPago;
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

        public bool Eliminar(OrdenDePago ordenDePagoEntidad)
        {
            //Conexion a BBDD y validación de id generado
            //eg. 
            //SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandText = "SP_EliminarOrdenDePago";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Id", SqlDbType.Int).Value = ordenDePagoEntidad.id;
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
