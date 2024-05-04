namespace View.Forms
{
    partial class FrmUnosArtikla
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVrstaProizvoda = new System.Windows.Forms.ComboBox();
            this.txtProdajnaCena = new System.Windows.Forms.TextBox();
            this.cbPDV = new System.Windows.Forms.ComboBox();
            this.txtLager = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtVrednostBezPDV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVrednostPDV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv proizvoda";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(29, 53);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(358, 22);
            this.txtNaziv.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vrsta proizvoda";
            // 
            // cbVrstaProizvoda
            // 
            this.cbVrstaProizvoda.FormattingEnabled = true;
            this.cbVrstaProizvoda.Location = new System.Drawing.Point(32, 111);
            this.cbVrstaProizvoda.Name = "cbVrstaProizvoda";
            this.cbVrstaProizvoda.Size = new System.Drawing.Size(355, 24);
            this.cbVrstaProizvoda.TabIndex = 7;
            // 
            // txtProdajnaCena
            // 
            this.txtProdajnaCena.Location = new System.Drawing.Point(32, 163);
            this.txtProdajnaCena.Name = "txtProdajnaCena";
            this.txtProdajnaCena.Size = new System.Drawing.Size(354, 22);
            this.txtProdajnaCena.TabIndex = 10;
            this.txtProdajnaCena.TextChanged += new System.EventHandler(this.txtProdajnaCena_TextChanged);
            // 
            // cbPDV
            // 
            this.cbPDV.FormattingEnabled = true;
            this.cbPDV.Location = new System.Drawing.Point(33, 216);
            this.cbPDV.Name = "cbPDV";
            this.cbPDV.Size = new System.Drawing.Size(104, 24);
            this.cbPDV.TabIndex = 8;
            this.cbPDV.SelectedValueChanged += new System.EventHandler(this.cbPDV_SelectedValueChanged);
            // 
            // txtLager
            // 
            this.txtLager.Location = new System.Drawing.Point(32, 386);
            this.txtLager.Name = "txtLager";
            this.txtLager.Size = new System.Drawing.Size(354, 22);
            this.txtLager.TabIndex = 14;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(23, 543);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(365, 72);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "Sacuvaj proizvod";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtVrednostBezPDV
            // 
            this.txtVrednostBezPDV.Location = new System.Drawing.Point(32, 273);
            this.txtVrednostBezPDV.Name = "txtVrednostBezPDV";
            this.txtVrednostBezPDV.ReadOnly = true;
            this.txtVrednostBezPDV.Size = new System.Drawing.Size(354, 22);
            this.txtVrednostBezPDV.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(30, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vrsta PDV-a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(30, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vrednost bez PDV-a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(30, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Prodajna cena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(32, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vrednost PDV-a";
            // 
            // txtVrednostPDV
            // 
            this.txtVrednostPDV.Location = new System.Drawing.Point(34, 327);
            this.txtVrednostPDV.Name = "txtVrednostPDV";
            this.txtVrednostPDV.ReadOnly = true;
            this.txtVrednostPDV.Size = new System.Drawing.Size(354, 22);
            this.txtVrednostPDV.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(30, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Pocetno stanje na lageru";
            // 
            // FrmUnosArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 632);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLager);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVrednostPDV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProdajnaCena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPDV);
            this.Controls.Add(this.cbVrstaProizvoda);
            this.Controls.Add(this.txtVrednostBezPDV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSacuvaj);
            this.Name = "FrmUnosArtikla";
            this.Text = "Unos novog artikla";
            this.Load += new System.EventHandler(this.FrmUnosArtikla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVrednostBezPDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVrstaProizvoda;
        private System.Windows.Forms.ComboBox cbPDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProdajnaCena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVrednostPDV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLager;
    }
}