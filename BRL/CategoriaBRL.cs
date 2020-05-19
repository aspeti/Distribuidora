using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using COMMON;
using DAL;

namespace BRL
{
    public class CategoriaBRL : AbstractBRL
    {
        #region Propiedades y constructores
        public Categoria Cat { get; set; }
        public CategoriaDAL Dal { get; set; }

        public CategoriaBRL()
        {
            Dal = new CategoriaDAL();
        }

        public CategoriaBRL(Categoria Cat)
        {
            this.Cat = Cat;
            Dal = new CategoriaDAL(Cat);
        }


        #endregion

        #region Métodos  de la Clase

        public override void delete()
        {
            Dal.delete();
        }

        public override void insert()
        {
            Dal.insert(); 
        }

        public override DataTable select()
        {
            return Dal.select();
        }

        public override void update()
        {
            Dal.update();
        }

        public Categoria Get(int idCategoria)
        {
            return Dal.Get(idCategoria);

        }



        #endregion
    }
}