namespace Proyecto_Autómatas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtalfabeto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEstadoInicial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtestadosfinales = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumestados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(729, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 68);
            this.button1.TabIndex = 11;
            this.toolTip1.SetToolTip(this.button1, "Guardar autómata");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(729, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 70);
            this.button2.TabIndex = 12;
            this.toolTip1.SetToolTip(this.button2, "Salir");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTÓMATA DFA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(729, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 68);
            this.button3.TabIndex = 13;
            this.toolTip1.SetToolTip(this.button3, "Cargar autómata");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(29, 233);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(694, 262);
            this.dgv1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ingrese una cadena:";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(220, 556);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(250, 30);
            this.txtCadena.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(487, 551);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 39);
            this.button4.TabIndex = 17;
            this.toolTip1.SetToolTip(this.button4, "Verificar");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ingrese el alfabeto:";
            // 
            // txtalfabeto
            // 
            this.txtalfabeto.Location = new System.Drawing.Point(191, 19);
            this.txtalfabeto.Name = "txtalfabeto";
            this.txtalfabeto.Size = new System.Drawing.Size(250, 30);
            this.txtalfabeto.TabIndex = 19;
            this.toolTip1.SetToolTip(this.txtalfabeto, "Ingrese alfabeto");
            this.txtalfabeto.TextChanged += new System.EventHandler(this.txtalfabeto_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEstadoInicial);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtestadosfinales);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtnumestados);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtalfabeto);
            this.panel1.Location = new System.Drawing.Point(29, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 161);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtEstadoInicial
            // 
            this.txtEstadoInicial.Enabled = false;
            this.txtEstadoInicial.Location = new System.Drawing.Point(621, 16);
            this.txtEstadoInicial.Name = "txtEstadoInicial";
            this.txtEstadoInicial.Size = new System.Drawing.Size(100, 30);
            this.txtEstadoInicial.TabIndex = 25;
            this.txtEstadoInicial.TextChanged += new System.EventHandler(this.txtEstadoInicial_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Estado inicial:";
            // 
            // txtestadosfinales
            // 
            this.txtestadosfinales.Location = new System.Drawing.Point(221, 110);
            this.txtestadosfinales.Name = "txtestadosfinales";
            this.txtestadosfinales.Size = new System.Drawing.Size(220, 30);
            this.txtestadosfinales.TabIndex = 23;
            this.toolTip1.SetToolTip(this.txtestadosfinales, "Ingrese estado final");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ingrese el estado final:";
            // 
            // txtnumestados
            // 
            this.txtnumestados.Location = new System.Drawing.Point(284, 68);
            this.txtnumestados.Name = "txtnumestados";
            this.txtnumestados.Size = new System.Drawing.Size(157, 30);
            this.txtnumestados.TabIndex = 21;
            this.toolTip1.SetToolTip(this.txtnumestados, "Ingrese número de estados");
            this.txtnumestados.TextChanged += new System.EventHandler(this.txtnumestados_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ingrese el número de estados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(822, 669);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autómata";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtalfabeto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtestadosfinales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnumestados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstadoInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

