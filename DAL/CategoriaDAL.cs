using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using COMMON;


namespace DAL
{
    public class CategoriaDAL : AbstractDAL
    {
        #region propiedades y constructores

        public Categoria Cat { get; set; }


        public CategoriaDAL()
        {
        }

        public CategoriaDAL(Categoria Cat)
        {
            this.Cat = Cat;
        }

        #endregion

        #region Metodos de clase

        public override void delete()
        {
            string query = @"Update Categoria SET estado=0, fechaActualizacion = CURRENT_TIMESTAMP, idUsuario = @IdUsuario
                             WHERE IdCategoria = @IdCategoria";

            SqlCommand cmd;
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@IdCategoria", Cat.IdCategoria);
                cmd.Parameters.AddWithValue("@idUsuario", '1');

                Methods.ExecuteBasicCommand(cmd);
            }
            catch (Exception ex)
            {
                //OJO agregar al LOG de errores
                throw ex;
            }
        }

        public override void insert()
        {
            string query = @"insert into categoria (nombreCategoria, idUsuario)
                           values (@nombreCategoria, @idusuario)";

            SqlCommand cmd;
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@nombreCategoria", Cat.NombreCategoria);
                cmd.Parameters.AddWithValue("@idusuario", Cat.IdUsuario);

                Methods.ExecuteBasicCommand(cmd);
            }
            catch (Exception ex)
            {
                //OJO agregar al LOG de errores
                throw ex;
            }
        }

        public override DataTable select()
        {
            //esta consulta en vez del * puedes colocar le idestablecimiento nombre, municipio o el dato que quiera seleccionar, etc
            string consulta = @"select * from vwCategoria";
            DataTable res;  //variable que almacenara los datos de la tabla
            SqlCommand cmd; //variable para almacenar la conexion
            try
            {
                cmd = Methods.CreateBasicCommand(consulta);  //cremoa el comando basico
                res = Methods.ExecuteDataTableCommand(cmd); //llenamos en dr la tabla que queremos mostrar
               
            }
            catch (Exception err)
            {
                //OJO Escribir en el LOG
                throw err;
            }
            return res;
        }
    

        public override void update()
        {
            string query = @"Update Categoria SET nombreCategoria = @nombreCategoria, fechaActualizacion = CURRENT_TIMESTAMP, idusuario=@idUsuario
                            WHERE IdCategoria = @IdCategoria";

            SqlCommand cmd;
            try
            {
                cmd = Methods.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@nombreCategoria", Cat.NombreCategoria);
                cmd.Parameters.AddWithValue("@idusuario", Cat.IdUsuario);
                cmd.Parameters.AddWithValue("@IdCategoria", Cat.IdCategoria);

                Methods.ExecuteBasicCommand(cmd);
            }
            catch (Exception ex)
            {
                //OJO agregar al LOG de errores
                throw ex;
            }
        }

        public Categoria Get(int id)
        {
            Categoria res = null;          

            string query = @"Select idCategoria, nombreCategoria, estado, fechaRegistro, fechaActualizacion, idusuario
                             From Categoria
                             where idCategoria = @idcategoria;";

            SqlCommand cmd = null;
            SqlDataReader dr = null;

            try
            {
                cmd = Methods.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@idCategoria", id);
                dr = Methods.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new Categoria(byte.Parse(dr[0].ToString()),dr[1].ToString(),byte.Parse(dr[2].ToString()),DateTime.Parse(dr[3].ToString()),DateTime.Parse(dr[4].ToString()),int.Parse(dr[5].ToString()));
                }

            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                cmd.Connection.Close();
                dr.Close();
            }
            return res;
        }


        #endregion

    }
}