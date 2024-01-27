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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(238, 396);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnStampanje
            // 
            this.btnStampanje.Location = new System.Drawing.Point(13, 95);
            this.btnStampanje.Name = "btnStampanje";
            this.btnStampanje.Size = new System.Drawing.Size(245, 55);
            this.btnStampanje.TabIndex = 8;
            this.btnStampanje.Text = "Stampanje racuna";
            this.btnStampanje.UseVisualStyleBackColor = true;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(13, 34);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(245, 55);
            this.btnUnos.TabIndex = 7;
            this.btnUnos.Text = "Unos porudzbine";
            this.btnUnos.UseVisualStyleBackColor = true;
            // 
            // UCUnosPorudzbine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStampanje);
            this.Controls.Add(this.btnUnos);
            this.Name = "UCUnosPorudzbine";
            this.Size = new System.Drawing.Size(1180, 593);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStampanje;
        private System.Windows.Forms.Button btnUnos;
    }
}
