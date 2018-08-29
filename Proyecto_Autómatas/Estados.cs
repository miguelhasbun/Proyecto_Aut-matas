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

        public Estados(string name_State)
        {
            estado = name_State;
            tran = new List<Transiciones>();
        }

        public string getallstates()
        {
            string concate="";
            for (int i=0; i<tran.Count; i++)
            {
                concate += tran[i];
                if (i != tran.Count - 1)
                {
                    concate += ",";
                }
            }
            return concate;
        }
        public void addtransition(string entry, string new_state)
        {
            tran.Add(new Transiciones(entry, new_state));

        }

    }
}
