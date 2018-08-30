using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Autómatas
{
    public partial class NFA : Form
    {
        NFA_E nfa;
        private string vacio = "ø";
        public NFA()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NFA_Load(object sender, EventArgs e)
        {

        }


        //funciones nuevas
        public string[] getstatefinales()
        {
            return (txtestadosfinalesnfa.Text.Split(','));

        }
        public string getstateroot()
        {
            return (getstate()[0]);
        }

        public string[] getstate()
        {
            string[] arreglo = new string[Convert.ToInt32(txtnumestadosnfa.Text)];
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = "q" + i;

            }
            return arreglo;
        }
        public string[] getalfabeto()
        {
            return (txtalfabetonfa.Text.Split(','));
        }

        public Estados [] getallstate()
        {
            List<Estados> tmp= new List<Estados>();
            
            for (int i = 0; i < dgt1.RowCount; i++)
            {
                Estados en = new Estados(dgt1.Rows[i].Cells[0].Value.ToString());

                for (int j = 1; j < dgt1.ColumnCount; j++)
                {
                    if (dgt1.Rows[i].Cells[j].Value == null)
                    {
                        dgt1.Rows[i].Cells[j].Value = vacio;
                    }
                    string[] tmpdt = dgt1.Rows[i].Cells[j].Value.ToString().Split(',');
                    for (int t=0; t < tmpdt.Length; t++)
                    {
                        en.addtransition(dgt1.Columns[j].Name, tmpdt[t]);
                    }

                }
                tmp.Add(en);


            }

            return tmp.ToArray();
        }
        public void createnfa()
        {
            nfa = new NFA_E(getstateroot(), getstatefinales(), getalfabeto(), getallstate());
            Console.WriteLine("Estado inicial"+nfa.estd_inicial+""+ "Estados finales"+ nfa.st_finals_acept+""+ 
                "Alfabeto"+ nfa.alfab+ ""+ "Todos los estados"+ nfa.estados);
        }

        public void generatetable()
        {
            dgt1.Columns.Clear();

            string[] array = getstate();
           
            //CODIGO NECESARIO PARA CREAR LAS COLUMNAS AUTOMÁTICAMENTE.
            string[] cadenarreglo = getalfabeto();
            int longitud = cadenarreglo.Length;
            dgt1.ColumnCount = longitud + 1;
            dgt1.Columns[0].Name = "Estados";


            for (int i = 0; i < cadenarreglo.Length; i++)
            {
                dgt1.Columns[i + 1].Name = cadenarreglo[i];

            }

            //CODIGO NECESARIO PARA CREAR LAS FILAS.
            int p = dgt1.Rows.Count;
            DataGridView xq = new DataGridView();
            dgt1.RowCount = array.Length;
            int longi = array.Length;
            for (int i = 0; i < longi; i++)
            {
                dgt1.Rows[i].SetValues(getstate()[i]);
            }
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            createnfa();
            MessageBox.Show("DFA CREADO");
            nfa.getalltransicionesDFA();
            foreach (Transiciones et in nfa.getalltransicionesDFA())
            {
                MessageBox.Show(et.nextstate);
            }
            

        }

        private void txtnumestadosnfa_TextChanged(object sender, EventArgs e)
        {
            if (txtnumestadosnfa.Text != null)
            {
                txtEstadoInicialnfa.Text = "q0";
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            generatetable();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            Form1 frm = new Form1();
            nfa.getalltransicionesDFA();
            nfa.getstatefinales();
            ManagerDFA ry = nfa.converttodfa();
            frm.setdfamanager(ry);
            frm.cargartableDFA();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
