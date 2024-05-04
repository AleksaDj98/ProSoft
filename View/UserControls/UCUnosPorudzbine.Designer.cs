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
            this.dgwPorudzbina = new System.Windows.Forms.DataGridView();
            this.btnStampanje = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnObrisiArtikal = new System.Windows.Forms.Button();
            this.btnPonistiPorudzbinu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUkupnaCena = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTopliNapici = new System.Windows.Forms.TabPage();
            this.tabSokovi = new System.Windows.Forms.TabPage();
            this.tabVode = new System.Windows.Forms.TabPage();
            this.tabPivo = new System.Windows.Forms.TabPage();
            this.tabVino = new System.Windows.Forms.TabPage();
            this.tabZestina = new System.Windows.Forms.TabPage();
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flp2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flp3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flp4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flp5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flp6 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPorudzbina)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabTopliNapici.SuspendLayout();
            this.tabSokovi.SuspendLayout();
            this.tabVode.SuspendLayout();
            this.tabPivo.SuspendLayout();
            this.tabVino.SuspendLayout();
            this.tabZestina.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPorudzbina
            // 
            this.dgwPorudzbina.AllowUserToAddRows = false;
            this.dgwPorudzbina.AllowUserToDeleteRows = false;
            this.dgwPorudzbina.AllowUserToResizeColumns = false;
            this.dgwPorudzbina.AllowUserToResizeRows = false;
            this.dgwPorudzbina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPorudzbina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPorudzbina.Location = new System.Drawing.Point(17, 185);
            this.dgwPorudzbina.Margin = new System.Windows.Forms.Padding(4);
            this.dgwPorudzbina.MultiSelect = false;
            this.dgwPorudzbina.Name = "dgwPorudzbina";
            this.dgwPorudzbina.ReadOnly = true;
            this.dgwPorudzbina.RowHeadersVisible = false;
            this.dgwPorudzbina.RowHeadersWidth = 51;
            this.dgwPorudzbina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPorudzbina.Size = new System.Drawing.Size(325, 353);
            this.dgwPorudzbina.TabIndex = 9;
            // 
            // btnStampanje
            // 
            this.btnStampanje.Location = new System.Drawing.Point(17, 101);
            this.btnStampanje.Margin = new System.Windows.Forms.Padding(4);
            this.btnStampanje.Name = "btnStampanje";
            this.btnStampanje.Size = new System.Drawing.Size(327, 68);
            this.btnStampanje.TabIndex = 8;
            this.btnStampanje.Text = "Stampanje racuna";
            this.btnStampanje.UseVisualStyleBackColor = true;
            this.btnStampanje.Click += new System.EventHandler(this.btnStampanje_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(17, 26);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(327, 68);
            this.btnUnos.TabIndex = 7;
            this.btnUnos.Text = "Unos porudzbine";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnObrisiArtikal
            // 
            this.btnObrisiArtikal.Location = new System.Drawing.Point(17, 575);
            this.btnObrisiArtikal.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiArtikal.Name = "btnObrisiArtikal";
            this.btnObrisiArtikal.Size = new System.Drawing.Size(327, 68);
            this.btnObrisiArtikal.TabIndex = 11;
            this.btnObrisiArtikal.Text = "Obrisi artikal";
            this.btnObrisiArtikal.UseVisualStyleBackColor = true;
            this.btnObrisiArtikal.Click += new System.EventHandler(this.btnObrisiArtikal_Click);
            // 
            // btnPonistiPorudzbinu
            // 
            this.btnPonistiPorudzbinu.Location = new System.Drawing.Point(17, 647);
            this.btnPonistiPorudzbinu.Margin = new System.Windows.Forms.Padding(4);
            this.btnPonistiPorudzbinu.Name = "btnPonistiPorudzbinu";
            this.btnPonistiPorudzbinu.Size = new System.Drawing.Size(327, 68);
            this.btnPonistiPorudzbinu.TabIndex = 12;
            this.btnPonistiPorudzbinu.Text = "Ponisti porudzbinu";
            this.btnPonistiPorudzbinu.UseVisualStyleBackColor = true;
            this.btnPonistiPorudzbinu.Click += new System.EventHandler(this.btnPonistiPorudzbinu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ukupno:";
            // 
            // labelUkupnaCena
            // 
            this.labelUkupnaCena.Location = new System.Drawing.Point(251, 551);
            this.labelUkupnaCena.Name = "labelUkupnaCena";
            this.labelUkupnaCena.Size = new System.Drawing.Size(88, 16);
            this.labelUkupnaCena.TabIndex = 14;
            this.labelUkupnaCena.Text = "0";
            this.labelUkupnaCena.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTopliNapici);
            this.tabControl1.Controls.Add(this.tabSokovi);
            this.tabControl1.Controls.Add(this.tabVode);
            this.tabControl1.Controls.Add(this.tabPivo);
            this.tabControl1.Controls.Add(this.tabVino);
            this.tabControl1.Controls.Add(this.tabZestina);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(378, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 691);
            this.tabControl1.TabIndex = 15;
            // 
            // tabTopliNapici
            // 
            this.tabTopliNapici.Controls.Add(this.flp1);
            this.tabTopliNapici.Location = new System.Drawing.Point(4, 34);
            this.tabTopliNapici.Name = "tabTopliNapici";
            this.tabTopliNapici.Padding = new System.Windows.Forms.Padding(3);
            this.tabTopliNapici.Size = new System.Drawing.Size(1258, 653);
            this.tabTopliNapici.TabIndex = 0;
            this.tabTopliNapici.Text = "Topli napici";
            this.tabTopliNapici.UseVisualStyleBackColor = true;
            // 
            // tabSokovi
            // 
            this.tabSokovi.Controls.Add(this.flp2);
            this.tabSokovi.Location = new System.Drawing.Point(4, 34);
            this.tabSokovi.Name = "tabSokovi";
            this.tabSokovi.Padding = new System.Windows.Forms.Padding(3);
            this.tabSokovi.Size = new System.Drawing.Size(1264, 653);
            this.tabSokovi.TabIndex = 1;
            this.tabSokovi.Text = "Sokovi";
            this.tabSokovi.UseVisualStyleBackColor = true;
            // 
            // tabVode
            // 
            this.tabVode.Controls.Add(this.flp3);
            this.tabVode.Location = new System.Drawing.Point(4, 34);
            this.tabVode.Name = "tabVode";
            this.tabVode.Padding = new System.Windows.Forms.Padding(3);
            this.tabVode.Size = new System.Drawing.Size(1264, 653);
            this.tabVode.TabIndex = 2;
            this.tabVode.Text = "Vode";
            this.tabVode.UseVisualStyleBackColor = true;
            // 
            // tabPivo
            // 
            this.tabPivo.Controls.Add(this.flp4);
            this.tabPivo.Location = new System.Drawing.Point(4, 34);
            this.tabPivo.Name = "tabPivo";
            this.tabPivo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPivo.Size = new System.Drawing.Size(1264, 653);
            this.tabPivo.TabIndex = 3;
            this.tabPivo.Text = "Pivo";
            this.tabPivo.UseVisualStyleBackColor = true;
            // 
            // tabVino
            // 
            this.tabVino.Controls.Add(this.flp5);
            this.tabVino.Location = new System.Drawing.Point(4, 34);
            this.tabVino.Name = "tabVino";
            this.tabVino.Padding = new System.Windows.Forms.Padding(3);
            this.tabVino.Size = new System.Drawing.Size(1258, 653);
            this.tabVino.TabIndex = 4;
            this.tabVino.Text = "Vino";
            this.tabVino.UseVisualStyleBackColor = true;
            // 
            // tabZestina
            // 
            this.tabZestina.Controls.Add(this.flp6);
            this.tabZestina.Location = new System.Drawing.Point(4, 34);
            this.tabZestina.Name = "tabZestina";
            this.tabZestina.Padding = new System.Windows.Forms.Padding(3);
            this.tabZestina.Size = new System.Drawing.Size(1258, 653);
            this.tabZestina.TabIndex = 5;
            this.tabZestina.Text = "Zestina";
            this.tabZestina.UseVisualStyleBackColor = true;
            // 
            // flp1
            // 
            this.flp1.Location = new System.Drawing.Point(2, 1);
            this.flp1.Name = "flp1";
            this.flp1.Size = new System.Drawing.Size(1259, 655);
            this.flp1.TabIndex = 0;
            // 
            // flp2
            // 
            this.flp2.Location = new System.Drawing.Point(3, 1);
            this.flp2.Name = "flp2";
            this.flp2.Size = new System.Drawing.Size(1265, 655);
            this.flp2.TabIndex = 0;
            // 
            // flp3
            // 
            this.flp3.Location = new System.Drawing.Point(4, 0);
            this.flp3.Name = "flp3";
            this.flp3.Size = new System.Drawing.Size(1264, 652);
            this.flp3.TabIndex = 0;
            // 
            // flp4
            // 
            this.flp4.Location = new System.Drawing.Point(1, 1);
            this.flp4.Name = "flp4";
            this.flp4.Size = new System.Drawing.Size(1267, 651);
            this.flp4.TabIndex = 0;
            // 
            // flp5
            // 
            this.flp5.Location = new System.Drawing.Point(0, 0);
            this.flp5.Name = "flp5";
            this.flp5.Size = new System.Drawing.Size(1257, 652);
            this.flp5.TabIndex = 0;
            // 
            // flp6
            // 
            this.flp6.Location = new System.Drawing.Point(3, 2);
            this.flp6.Name = "flp6";
            this.flp6.Size = new System.Drawing.Size(1254, 650);
            this.flp6.TabIndex = 0;
            // 
            // UCUnosPorudzbine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelUkupnaCena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPonistiPorudzbinu);
            this.Controls.Add(this.btnObrisiArtikal);
            this.Controls.Add(this.dgwPorudzbina);
            this.Controls.Add(this.btnStampanje);
            this.Controls.Add(this.btnUnos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCUnosPorudzbine";
            this.Size = new System.Drawing.Size(1665, 729);
            this.Load += new System.EventHandler(this.UCUnosPorudzbine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPorudzbina)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabTopliNapici.ResumeLayout(false);
            this.tabSokovi.ResumeLayout(false);
            this.tabVode.ResumeLayout(false);
            this.tabPivo.ResumeLayout(false);
            this.tabVino.ResumeLayout(false);
            this.tabZestina.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPorudzbina;
        private System.Windows.Forms.Button btnStampanje;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnObrisiArtikal;
        private System.Windows.Forms.Button btnPonistiPorudzbinu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUkupnaCena;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTopliNapici;
        private System.Windows.Forms.TabPage tabSokovi;
        private System.Windows.Forms.TabPage tabVode;
        private System.Windows.Forms.TabPage tabPivo;
        private System.Windows.Forms.TabPage tabVino;
        private System.Windows.Forms.TabPage tabZestina;
        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.FlowLayoutPanel flp2;
        private System.Windows.Forms.FlowLayoutPanel flp3;
        private System.Windows.Forms.FlowLayoutPanel flp4;
        private System.Windows.Forms.FlowLayoutPanel flp5;
        private System.Windows.Forms.FlowLayoutPanel flp6;
    }
}
