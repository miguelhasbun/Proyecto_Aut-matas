using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Autómatas
{
    public class NFA_E
    {
        public string estd_inicial;
        public string[] st_finals_acept;
        public string[] alfab;
        public Estados[] estados;
        public NFA_E(string eini, string[] est_fin_a, string [] alf, Estados [] e)
        {
            estd_inicial = eini;
            st_finals_acept = est_fin_a;
            alfab = alf;
            estados = e;
        }

        public Transiciones gettransicion(string name_state, string input)
        {
            foreach(Estados i in estados)
            {
               foreach(Transiciones e in i.getransicion(alfab))
                {
                    if (i.estado== name_state && e.arista==input)
                    {
                        return e;
                    }
                }
               
            }
            return null;
        }
        public Transiciones[] getalltransicionesDFA()
        {
            List<Transiciones> tnDFA = new List<Transiciones>();
            foreach(string t in alfab)
            {
                tnDFA.Add(gettransicion(estd_inicial, t));
            }
            return tnDFA.ToArray();
        }

    }
}
