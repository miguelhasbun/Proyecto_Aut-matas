using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Autómatas
{
    public class NFA_Epsilon
    {
        public string estd_inicial;
        public string[] st_finals_acept;
        public string[] alfab;
        public Estados[] estados;
        public NFA_Epsilon(string eini, string[] est_fin_a, string[] alf, Estados[] e)
        {
            estd_inicial = eini;
            st_finals_acept = est_fin_a;
            alfab = alf;
            estados = e;
        }
    }
}
