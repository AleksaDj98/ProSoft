namespace View.Forms
{
    partial class FrmLager
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
            this.btnPromenaStanja = new System.Windows.Forms.Button();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.rbNabavka = new System.Windows.Forms.RadioButton();
            this.rbRashod = new System.Windows.Forms.RadioButton();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPromenaStanja
            // 
            this.btnPromenaStanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPromenaStanja.Location = new System.Drawing.Point(477, 673);
            this.btnPromenaStanja.Name = "btnPromenaStanja";
            this.btnPromenaStanja.Size = new System.Drawing.Size(257, 45);
            this.btnPromenaStanja.TabIndex = 0;
            this.btnPromenaStanja.Text = "Promeni stanje";
            this.btnPromenaStanja.UseVisualStyleBackColor = true;
            this.btnPromenaStanja.Click += new System.EventHandler(this.btnPromenaStanja_Click);
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(20, 62);
            this.dgvProizvodi.MultiSelect = false;
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.RowHeadersWidth = 51;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(713, 503);
            this.dgvProizvodi.TabIndex = 1;
            // 
            // rbNabavka
            // 
            this.rbNabavka.AutoSize = true;
            this.rbNabavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbNabavka.Location = new System.Drawing.Point(478, 580);
            this.rbNabavka.Name = "rbNabavka";
            this.rbNabavka.Size = new System.Drawing.Size(102, 26);
            this.rbNabavka.TabIndex = 2;
            this.rbNabavka.TabStop = true;
            this.rbNabavka.Text = "Nabavka";
            this.rbNabavka.UseVisualStyleBackColor = true;
            this.rbNabavka.CheckedChanged += new System.EventHandler(this.rbNabavka_CheckedChanged);
            // 
            // rbRashod
            // 
            this.rbRashod.AutoSize = true;
            this.rbRashod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbRashod.Location = new System.Drawing.Point(638, 579);
            this.rbRashod.Name = "rbRashod";
            this.rbRashod.Size = new System.Drawing.Size(93, 26);
            this.rbRashod.TabIndex = 3;
            this.rbRashod.TabStop = true;
            this.rbRashod.Text = "Rashod";
            this.rbRashod.UseVisualStyleBackColor = true;
            this.rbRashod.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretraga.Location = new System.Drawing.Point(20, 23);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(711, 30);
            this.txtPretraga.TabIndex = 5;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKolicina.Location = new System.Drawing.Point(557, 623);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(176, 27);
            this.txtKolicina.TabIndex = 6;
            this.txtKolicina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKolicina_KeyPress);
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolicina.Location = new System.Drawing.Point(473, 624);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(78, 22);
            this.lblKolicina.TabIndex = 7;
            this.lblKolicina.Text = "Kolicina:";
            // 
            // FrmLager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 742);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.rbRashod);
            this.Controls.Add(this.rbNabavka);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.btnPromenaStanja);
            this.Name = "FrmLager";
            this.Text = "Lager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPromenaStanja;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.RadioButton rbNabavka;
        private System.Windows.Forms.RadioButton rbRashod;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
    }
}