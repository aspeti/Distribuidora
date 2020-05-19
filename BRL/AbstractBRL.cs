using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRL
{
    public abstract class AbstractBRL
    {
        public abstract void insert();
        public abstract void update();
        public abstract void delete();
        public abstract DataTable select();
    }
}
