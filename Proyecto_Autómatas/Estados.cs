using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Autómatas
{
    public class Estados
    {
        public string estado;
        public List<Transiciones> tran;

        public Estados(string ts, List<Transiciones>t)
        {
            estado = ts;
            tran = t;
        }

    }
}
