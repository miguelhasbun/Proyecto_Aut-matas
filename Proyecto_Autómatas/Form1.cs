using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Proyecto_Autómatas
{
    
    public partial class Form1 : Form
    {
        ManagerDFA ina;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

              getestado();
              
             if (txtalfabeto.Text == "")
             {
                 error1.SetError(txtalfabeto, "Ingrese un alfabeto");
                 txtalfabeto.Focus();
                 return;
             }
             error1.SetError(txtalfabeto, "");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            generateDFA();
            evaluarcadena();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //string fileJson = File.ReadAllText(@"C:\Users\Miguel Hasbun\Documents\JsonConvert.json");
            
            
            dgv1.Columns.Clear();
            
            string[] array = getstates(Convert.ToInt32(txtnumestados.Text));
            for (int i = 0; i < array.Length; i++)
            {
                //MessageBox.Show(array[i]);
            }

            //CODIGO NECESARIO PARA CREAR LAS COLUMNAS AUTOMÁTICAMENTE.
            string cadena = txtalfabeto.Text;
            string[] cadenarreglo = cadena.Split(',');
            int longitud = cadenarreglo.Length;
            dgv1.ColumnCount = longitud+1;
            dgv1.Columns[0].Name = "Estados";
            

            for (int i=0; i < cadenarreglo.Length; i++)
            {
                dgv1.Columns[i+1].Name = cadenarreglo[i];

            }

            //CODIGO NECESARIO PARA CREAR LAS FILAS.
            int p = dgv1.Rows.Count;
            DataGridView xq = new DataGridView();
            dgv1.RowCount = array.Length;
            int longi = array.Length;
            for (int i = 0; i < longi; i++)
            {
                dgv1.Rows[i].SetValues("q" + i);
                //MessageBox.Show(array[i]);
            }


       
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEstadoInicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtalfabeto_TextChanged(object sender, EventArgs e)
        {
            
        }


       public string [] getstates(int num)
        {
            string[] arreglo = new string[num];
            for (int i=0; i < arreglo.Length; i++)
            {
                arreglo[i] = "q" + i;
                
            }
            return arreglo;
        }

        private void button5_Click(object sender, EventArgs e)
        {
        
        }

        private void txtnumestados_TextChanged(object sender, EventArgs e)
        {
          if (txtnumestados.Text != null)
            {
                txtEstadoInicial.Text = "q0";
            }
            
        }

        public Estados[] getestado()
        {
            string op = "";
            List<Estados> tmp = new List<Estados>();
            //for (int i = 0; i < dgv1.Columns.Count; i++)
            //{

            //    op += dgv1.Columns[i].Name;
            //}
          //  MessageBox.Show(op);
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                List<Transiciones> t = new List<Transiciones>();
                for (int j = 1; j < dgv1.ColumnCount; j++)
                {
                    t.Add(new Transiciones(dgv1.Columns[j].Name.ToString(), dgv1.Rows[i].Cells[j].Value.ToString()));

                }
                tmp.Add(new Estados(dgv1.Rows[i].Cells[0].Value.ToString(),t ));


            }
            
          return tmp.ToArray();
            
        }
        public void generateDFA()
        {
            ina = new ManagerDFA(txtEstadoInicial.Text, txtestadosfinales.Text.Split(','), getestado(), txtalfabeto.Text.Split(','));
        }

        public void evaluarcadena()
        {
            string xcad = txtCadena.Text;
            for (int i=0; i < xcad.ToCharArray().Length; i++)
            {
                char tmep = xcad.ToCharArray()[i];
                ina.recorrerautomata(tmep.ToString());
            }
            MessageBox.Show(ina.isaceptado() ? "Aceptado" : "No aceptado");
            ina.reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
    }
    

