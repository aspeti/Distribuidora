using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Methods
    {
        static string cadconnection = @"Data Source=localhost;Initial Catalog=dbpedidos;User ID=user; Password=user";
        static SqlConnection connection;

        #region Crear Comandos
        public static SqlCommand createBasicCommand ()
        {
            connection = new SqlConnection(cadconnection);
            SqlCommand res = new SqlCommand();
            res.Connection = connection;

            return res;
        }

        public static SqlCommand CreateBasicCommand(string query)
        {
            SqlConnection connection = new SqlConnection(cadconnection);
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = connection;
            return cmd;
        }
        #endregion

        #region Ejecucion de comandos
        public static void ExecuteBasicCommand(SqlCommand cmd)
        {
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                cmd.Connection.Close();
            }

        }

        public static DataTable ExecuteDataTableCommand(SqlCommand cmd)
        {
            DataTable dt = new DataTable(); // componente ADO

            try
            {
                cmd.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd); 
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return dt;
        }

        //Este metodo es usado solo por el GET 
        public static SqlDataReader ExecuteDataReaderCommand(SqlCommand cmd) 
        {
            SqlDataReader dr = null;
            try
            {
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
            }
            catch (Exception err)
            {
                throw err;
            }
            return dr;
        }

        #endregion

    }
}
