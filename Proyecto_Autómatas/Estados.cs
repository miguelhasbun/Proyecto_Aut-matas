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
            tran.Add(new Transiciones(estado, entry, new_state));

        }
        public Transiciones[] getransicion()
        {
            return tran.ToArray();
        }
        public Transiciones[] getransicion(string [] alfabeto)
        {
            return unirtrans(alfabeto);
        }

        public Transiciones[] getAllTrancionesConEntry(String entry)
        {
            List<Transiciones> tmp_transicciones = new List<Transiciones>();
            foreach (Transiciones t in tran)
            {
                if (t.arista==(entry))
                {
                    tmp_transicciones.Add(t);
                }
            }
            return tmp_transicciones.ToArray();
        }


        public Transiciones[] unirtrans(string[] alfabeto)
        {

            List<Transiciones> taq = new List<Transiciones>();
                foreach(string ta in alfabeto)
                {
                string temp = "";
                for (int i = 0; i < tran.Count; i++)
                {
                    if (tran[i].arista == ta)
                    {
                        temp += tran[i].nextstate;
                      
                       
                    }
                    if (i != (tran.Count - 1)&& tran[i].arista==ta)
                    {
                        temp += ",";
                    }


                }
                taq.Add(new Transiciones(ta, temp));

                }
            return taq.ToArray();
        }
        
        }

    }

