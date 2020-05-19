using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON
{
    public class Categoria
    {
        #region Propiedades

        public byte IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public byte Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public int IdUsuario { get; set; }

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor para el GET
        /// </summary>
        /// <param name="IdCategoria"></param>
        /// <param name="NombreCategoria"></param>
        /// <param name="Estado"></param>
        /// <param name="FechaRegistro"></param>
        /// <param name="FechaActualizacion"></param>
        /// <param name="IdUsuario"></param>
        public Categoria(byte IdCategoria, string NombreCategoria, byte Estado, DateTime FechaRegistro, DateTime FechaActualizacion, int IdUsuario)
        {
            this.IdCategoria = IdCategoria;
            this.NombreCategoria = NombreCategoria;
            this.Estado = Estado;
            this.FechaRegistro = FechaRegistro;
            this.FechaActualizacion = FechaActualizacion;
            this.IdUsuario = IdUsuario;
        }
        /// <summary>
        /// Constructor para el Insert
        /// </summary>
        /// <param name="NombreCategoria"></param>
        /// <param name="IdUsuario"></param>
        public Categoria(string NombreCategoria, int IdUsuario)
        {            
            this.NombreCategoria = NombreCategoria;            
            this.IdUsuario = IdUsuario;
        } 

        #endregion



    }
}
