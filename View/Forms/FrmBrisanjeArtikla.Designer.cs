namespace View.Forms
{
    partial class FrmBrisanjeArtikla
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
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazivProizvoda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(499, 555);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(196, 58);
            this.btnObrisi.TabIndex = 0;
            this.btnObrisi.Text = "Promeni status";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(23, 66);
            this.dgvProizvodi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProizvodi.MultiSelect = false;
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.RowHeadersWidth = 51;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(672, 468);
            this.dgvProizvodi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unesite naziv proizvoda";
            // 
            // txtNazivProizvoda
            // 
            this.txtNazivProizvoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazivProizvoda.Location = new System.Drawing.Point(195, 15);
            this.txtNazivProizvoda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNazivProizvoda.Name = "txtNazivProizvoda";
            this.txtNazivProizvoda.Size = new System.Drawing.Size(500, 24);
            this.txtNazivProizvoda.TabIndex = 3;
            this.txtNazivProizvoda.TextChanged += new System.EventHandler(this.txtNazivProizvoda_TextChanged);
            // 
            // FrmBrisanjeArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 641);
            this.Controls.Add(this.txtNazivProizvoda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.btnObrisi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmBrisanjeArtikla";
            this.Text = "Brisanje Artikla";
            this.Load += new System.EventHandler(this.FrmBrisanjeArtikla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivProizvoda;
    }
}