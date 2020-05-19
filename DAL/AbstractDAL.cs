using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public abstract class AbstractDAL
    {
        public abstract void insert();
        public abstract void update();
        public abstract void delete();
        public abstract DataTable select();

    }
}
