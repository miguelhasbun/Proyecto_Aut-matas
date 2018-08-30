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
        public Transiciones(string ar, string next)
        {
            arista = ar;
            nextstate = next;
        }
        


    }
}
