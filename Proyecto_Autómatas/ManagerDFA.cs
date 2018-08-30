using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Autómatas
{
    public class ManagerDFA
    {
        public string ein;
        public string[] efin;
        public Estados[] et;
        public string[] alfa;
        public string currentstate;
        public ManagerDFA(string ei, string[] ef, Estados[] e, string[] al)
        {
            ein = ei;
            efin = ef;
            et = e;
            alfa = al;
            currentstate = ei;
        }

        public string[] getstate()
        {
            List<string> ot = new List<string>();
            foreach(Estados e in et)
            {
                ot.Add(e.estado);
            }
            return ot.ToArray();
        }

        public bool isaceptado()
        {
            for (int i=0; i < efin.Length; i++)
            {
                if (currentstate == efin[i])
                {
                    return true;
                }
            }
            return false;
        }

        public Estados currenstatea(String q)
        {
            for (int i=0; i < et.Length; i++)
            {
                if (et[i].estado == q)
                {
                    return et[i];
                }
            }
            return null;
        }
        public void recorrerautomata(string nu)
        {
            
            string estado_actual = currentstate;
            Estados t_miestado = currenstatea(estado_actual);
             currentstate=statesiguiente(nu, t_miestado).estado;
            
        }
        public void reset()
        {
            currentstate = ein;
        }
        Estados statesiguiente(string est, Estados e)
        {
            if (e == null) return null;
            if (e.tran == null)
            {
                return null;
            }
            for (int i=0; i<e.tran.Count; i++)
            {
                if(e.tran[i].arista== est)
                {
                    return currenstatea(e.tran[i].nextstate);
                }
            }
            return null;
        }

        public Transiciones gettransicion(string nombreest, string arista)
        {
            foreach(Estados eta in et)
            {
                foreach(Transiciones op in eta.tran)
                {
                    if (eta.estado== nombreest && op.arista==arista)
                    {
                        return op;
                    }
                }
            }
            return null;
        }
    }
}
