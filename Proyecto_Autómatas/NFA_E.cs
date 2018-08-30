using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Autómatas
{
    public class NFA_E
    {
        private string vacio="ø";
        public Estados[] DFASTATES;
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
        public Estados buscarEstado(String name)
        {
            foreach (Estados estado in estados)
            {
                if (estado.estado==(name))
                {
                    return estado;
                }
            }
            return null;
        }

        private bool esIgualEstado(string estado, string estadosExistente)
        {
            foreach (string c in estado.Split(','))
            {
                if (!estadosExistente.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }


        private bool existEstado(Transiciones transicion, String estado, List<Estados> estadosExistentes)
        {
            
            bool exist = false;
            if (estado.Contains(vacio) || estado.ToCharArray()[0]==',')
            {
                return true;
            }
            foreach (Estados estadosExistente in estadosExistentes)
            {
                if (estadosExistente.estado==(estado))
                {
                    return true;
                }
                else if (estado.Length == estadosExistente.estado.Length)
                {

                    exist = esIgualEstado(estado, estadosExistente.estado);
                    if (exist)
                    {
                        transicion.nextstate=(estadosExistente.estado);
                    }
                }
            }
            return exist;
        }

        private Transiciones[] getTransicionesNFA()
        {
            List<Transiciones> tmpTranciones = new List<Transiciones>();
            foreach (Estados e in estados)
            {
                foreach (Transiciones t in e.getransicion())
                {
                    tmpTranciones.Add(t);
                }
            }
            return tmpTranciones.ToArray();

        }

        private string getEstadosNuevo(string chainEstados, string chainEstados2)
        {

            List<string> listEstados = new List<string>();

            foreach (string c in chainEstados.Split(','))
            {
                if (!c.Contains(vacio))
                {
                    listEstados.Add(c);
                }
            }

            foreach (string estado in chainEstados2.Split(','))
            {
                if (!chainEstados.Contains(estado) && estado!=(vacio))
                {
                    listEstados.Add(estado);
                }
            }


            String nuevosEstados = "";
            for (int i = 0; i < listEstados.Count; i++)
            {
                nuevosEstados += listEstados[i];
                if (i != listEstados.Count - 1)
                {
                    nuevosEstados += ",";
                }
            }

            return nuevosEstados;
        }



        public string gettransicion(string[] stado, string aristaTrascision)
        {
            string tempInput = vacio;
            foreach (string est in stado)
            {
                foreach (Transiciones t in getTransicionesNFA() )
                {
                    if (t.estad==(est) && t.arista==(aristaTrascision))
                    {
                        tempInput = getEstadosNuevo(tempInput, t.nextstate);
                    }
                }
            }
            return tempInput==("") ? vacio : tempInput;
        }




        private Transiciones getNuevoEstado(List<Estados> estadosExistentes, List<Transiciones> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                if (!existEstado(array[i], array[i].nextstate, estadosExistentes))
                {
                    return array[i];
                }
            }
            return null;
        }

        private bool existenTransicionVacias(List<Transiciones> tmp_transiciones)
        {
            foreach (Transiciones t in tmp_transiciones)
            {
                if (t.nextstate==(vacio))
                {
                    return true;
                }
            }
            return false;
        }
        private void addnewstatedeath(List<Transiciones> tmp_transiciones, List<Estados> estado_existentes)
        {
            foreach (string alphabet in alfab)
            {
                tmp_transiciones.Add(new Transiciones("qm", alphabet, "qm"));
            }
            estado_existentes.Add(new Estados("qm"));
            for (int i = 0; i < tmp_transiciones.Count; i++)
            {
                if (tmp_transiciones[i].nextstate==(vacio))
                {
                    tmp_transiciones[i].nextstate=("qm");
                }
            }
        }




        public Transiciones[] getalltransicionesDFA()
        {
            List<Transiciones> tnDFA = new List<Transiciones>();
            List<Estados> e_exis = new List<Estados>();
            Estados eta = buscarEstado(estd_inicial);

            foreach (string t in alfab)
            {
                string tmp_tr = "";
                Transiciones[] tmp_alltran = eta.getAllTrancionesConEntry(t);
                for (int i=0; i < tmp_alltran.Length; i++)
                {
                    tmp_tr += tmp_alltran[i].nextstate;
                    if (i != tmp_alltran.Length - 1)
                    {
                        tmp_tr += ",";
                    }

                }
                tnDFA.Add(new Transiciones(eta.estado, t, tmp_tr));
            }
            e_exis.Add(eta);

            while (getNuevoEstado(e_exis, tnDFA) != null)
            {
                Transiciones trans = getNuevoEstado(e_exis, tnDFA);
                string tmp_find = vacio;
                foreach(string altp in alfab)
                {
                    tmp_find = gettransicion(trans.nextstate.Split(','), altp);
                    if (tmp_find.ToCharArray()[0] == ',')
                    {
                        tmp_find= tmp_find.Substring(1, tmp_find.Length-1);
                    }
                     
                    tnDFA.Add(new Transiciones(trans.nextstate, altp, tmp_find));

                }

                if (trans.nextstate!=(vacio) || trans.nextstate==(""))
                {
                    e_exis.Add(new Estados(trans.nextstate));
                }
            }
            if (existenTransicionVacias(tnDFA))
            {
                addnewstatedeath(tnDFA, e_exis);
            }
            DFASTATES = e_exis.ToArray();
            return tnDFA.ToArray();
        }
        //string ei, string[] ef, Estados[] e, string[] al
        public string[] getstatefinales()
        {
            List<string> tmpfin = new List<string>();
            foreach(Estados e in DFASTATES)
            {
                if (st_finals_acept.Contains(e.estado))
                {
                    tmpfin.Add(e.estado);
                }
            }
            return tmpfin.ToArray();
        }

        public ManagerDFA converttodfa()
        {
            Transiciones[] temp_transicciones = getalltransicionesDFA();

            for (int i=0; i<DFASTATES.Length;i++)
            {
                foreach(Transiciones ap in temp_transicciones)
                {
                    if (ap.estad.Equals(DFASTATES[i].estado))
                    {
                        DFASTATES[i].tran.Add(ap);
                    }
                }
            }
            return new ManagerDFA(estd_inicial, getstatefinales(), DFASTATES, alfab);
        } 

    }
}
