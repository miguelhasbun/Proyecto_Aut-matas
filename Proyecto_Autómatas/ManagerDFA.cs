using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Autómatas
{
    public class ManagerDFA
    {
        string ein;
        string[] efin;
        Estados[] et;
        string[] alfa;
        string currentstate;
        public ManagerDFA(string ei, string[] ef, Estados[] e, string[] al)
        {
            ein = ei;
            efin = ef;
            et = e;
            alfa = al;
            currentstate = ei;
        }
        public Boolean isaceptado()
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
            for (int i=0; i<e.tran.Count; i++)
            {
                if(e.tran[i].arista== est)
                {
                    return currenstatea(e.tran[i].nextstate);
                }
            }
            return null;
        }
    }
}
