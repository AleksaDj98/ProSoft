namespace View.UserControls
{
    partial class UCUnosPorudzbine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnStampanje = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.gpProizvodi = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 209);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(317, 487);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnStampanje
            // 
            this.btnStampanje.Location = new System.Drawing.Point(17, 117);
            this.btnStampanje.Margin = new System.Windows.Forms.Padding(4);
            this.btnStampanje.Name = "btnStampanje";
            this.btnStampanje.Size = new System.Drawing.Size(327, 68);
            this.btnStampanje.TabIndex = 8;
            this.btnStampanje.Text = "Stampanje racuna";
            this.btnStampanje.UseVisualStyleBackColor = true;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(17, 42);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(327, 68);
            this.btnUnos.TabIndex = 7;
            this.btnUnos.Text = "Unos porudzbine";
            this.btnUnos.UseVisualStyleBackColor = true;
            // 
            // gpProizvodi
            // 
            this.gpProizvodi.Location = new System.Drawing.Point(379, 22);
            this.gpProizvodi.Name = "gpProizvodi";
            this.gpProizvodi.Size = new System.Drawing.Size(1159, 689);
            this.gpProizvodi.TabIndex = 10;
            this.gpProizvodi.TabStop = false;
            this.gpProizvodi.Text = "Proizvodi";
            // 
            // UCUnosPorudzbine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpProizvodi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStampanje);
            this.Controls.Add(this.btnUnos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCUnosPorudzbine";
            this.Size = new System.Drawing.Size(1573, 730);
            this.Load += new System.EventHandler(this.UCUnosPorudzbine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStampanje;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.GroupBox gpProizvodi;
    }
}
