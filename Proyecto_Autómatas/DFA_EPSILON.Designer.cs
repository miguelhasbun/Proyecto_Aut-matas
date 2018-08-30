namespace Proyecto_Autómatas
{
    partial class DFA_EPSILON
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DFA_EPSILON));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEstadoInicialnfae = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtestadosfinalesnfae = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumestadosnfae = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtalfabetonfae = new System.Windows.Forms.TextBox();
            this.dgt1 = new System.Windows.Forms.DataGridView();
            this.btnhomeok = new System.Windows.Forms.Button();
            this.btnconvert = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "AUTÓMATA NFA-ε";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEstadoInicialnfae);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtestadosfinalesnfae);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtnumestadosnfae);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtalfabetonfae);
            this.panel1.Location = new System.Drawing.Point(28, 113);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 224);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtEstadoInicialnfae
            // 
            this.txtEstadoInicialnfae.Enabled = false;
            this.txtEstadoInicialnfae.Location = new System.Drawing.Point(692, 91);
            this.txtEstadoInicialnfae.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstadoInicialnfae.Name = "txtEstadoInicialnfae";
            this.txtEstadoInicialnfae.Size = new System.Drawing.Size(136, 30);
            this.txtEstadoInicialnfae.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Estado inicial:";
            // 
            // txtestadosfinalesnfae
            // 
            this.txtestadosfinalesnfae.Location = new System.Drawing.Point(288, 162);
            this.txtestadosfinalesnfae.Margin = new System.Windows.Forms.Padding(4);
            this.txtestadosfinalesnfae.Name = "txtestadosfinalesnfae";
            this.txtestadosfinalesnfae.Size = new System.Drawing.Size(301, 30);
            this.txtestadosfinalesnfae.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ingrese el estado final:";
            // 
            // txtnumestadosnfae
            // 
            this.txtnumestadosnfae.Location = new System.Drawing.Point(288, 95);
            this.txtnumestadosnfae.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumestadosnfae.Name = "txtnumestadosnfae";
            this.txtnumestadosnfae.Size = new System.Drawing.Size(214, 30);
            this.txtnumestadosnfae.TabIndex = 21;
            this.txtnumestadosnfae.TextChanged += new System.EventHandler(this.txtnumestadosnfa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ingrese el número de estados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ingrese el alfabeto:";
            // 
            // txtalfabetonfae
            // 
            this.txtalfabetonfae.Location = new System.Drawing.Point(288, 27);
            this.txtalfabetonfae.Margin = new System.Windows.Forms.Padding(4);
            this.txtalfabetonfae.Name = "txtalfabetonfae";
            this.txtalfabetonfae.Size = new System.Drawing.Size(342, 30);
            this.txtalfabetonfae.TabIndex = 19;
            // 
            // dgt1
            // 
            this.dgt1.AllowUserToAddRows = false;
            this.dgt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt1.Location = new System.Drawing.Point(28, 390);
            this.dgt1.Name = "dgt1";
            this.dgt1.RowTemplate.Height = 24;
            this.dgt1.Size = new System.Drawing.Size(864, 150);
            this.dgt1.TabIndex = 23;
            // 
            // btnhomeok
            // 
            this.btnhomeok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhomeok.BackgroundImage")));
            this.btnhomeok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhomeok.Location = new System.Drawing.Point(524, 578);
            this.btnhomeok.Name = "btnhomeok";
            this.btnhomeok.Size = new System.Drawing.Size(66, 70);
            this.btnhomeok.TabIndex = 28;
            this.btnhomeok.UseVisualStyleBackColor = true;
            this.btnhomeok.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnconvert
            // 
            this.btnconvert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnconvert.BackgroundImage")));
            this.btnconvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnconvert.Location = new System.Drawing.Point(401, 578);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(66, 68);
            this.btnconvert.TabIndex = 27;
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguardar.BackgroundImage")));
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.Location = new System.Drawing.Point(291, 578);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(66, 68);
            this.btnguardar.TabIndex = 26;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // DFA_EPSILON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(906, 660);
            this.Controls.Add(this.btnhomeok);
            this.Controls.Add(this.btnconvert);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dgt1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DFA_EPSILON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NFA_EPSILON";
            this.Load += new System.EventHandler(this.DFA_EPSILON_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEstadoInicialnfae;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtestadosfinalesnfae;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnumestadosnfae;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtalfabetonfae;
        private System.Windows.Forms.DataGridView dgt1;
        private System.Windows.Forms.Button btnhomeok;
        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.Button btnguardar;
    }
}