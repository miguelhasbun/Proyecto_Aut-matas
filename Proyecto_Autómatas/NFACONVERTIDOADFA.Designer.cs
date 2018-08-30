namespace Proyecto_Autómatas
{
    partial class NFACONVERTIDOADFA
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
            this.dgt1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgt1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgt1
            // 
            this.dgt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt1.Location = new System.Drawing.Point(99, 71);
            this.dgt1.Name = "dgt1";
            this.dgt1.RowTemplate.Height = 24;
            this.dgt1.Size = new System.Drawing.Size(684, 330);
            this.dgt1.TabIndex = 0;
            // 
            // NFACONVERTIDOADFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 502);
            this.Controls.Add(this.dgt1);
            this.Name = "NFACONVERTIDOADFA";
            this.Text = "NFACONVERTIDOADFA";
            ((System.ComponentModel.ISupportInitialize)(this.dgt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgt1;
    }
}