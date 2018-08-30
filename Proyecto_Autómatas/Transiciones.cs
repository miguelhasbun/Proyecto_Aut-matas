using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Autómatas
{
    public class Transiciones
    {
        public string arista;
        public string  nextstate;
        public string estad;
        public Transiciones(string ar, string next)
        {
            arista = ar;
            nextstate = next;
        }
        public Transiciones(string estado, string arist, string next)
        {
            estad = estado;
            arista = arist;
            nextstate = next;
        }
        


    }
}
