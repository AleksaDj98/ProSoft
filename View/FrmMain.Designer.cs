namespace View
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dnevniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZaposleniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogZaposlenogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeZaposlenogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cenovnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogArtiklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledArtiklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izvestajiToolStripMenuItem,
            this.ZaposleniToolStripMenuItem,
            this.cenovnikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1294, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dnevniToolStripMenuItem});
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.izvestajiToolStripMenuItem.Text = "Izvestaji";
            // 
            // dnevniToolStripMenuItem
            // 
            this.dnevniToolStripMenuItem.Name = "dnevniToolStripMenuItem";
            this.dnevniToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.dnevniToolStripMenuItem.Text = "Dnevni";
            this.dnevniToolStripMenuItem.Click += new System.EventHandler(this.dnevniToolStripMenuItem_Click);
            // 
            // ZaposleniToolStripMenuItem
            // 
            this.ZaposleniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogZaposlenogToolStripMenuItem,
            this.brisanjeZaposlenogToolStripMenuItem});
            this.ZaposleniToolStripMenuItem.Name = "ZaposleniToolStripMenuItem";
            this.ZaposleniToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.ZaposleniToolStripMenuItem.Text = "Zaposleni";
            // 
            // unosNovogZaposlenogToolStripMenuItem
            // 
            this.unosNovogZaposlenogToolStripMenuItem.Name = "unosNovogZaposlenogToolStripMenuItem";
            this.unosNovogZaposlenogToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.unosNovogZaposlenogToolStripMenuItem.Text = "Unos novog zaposlenog";
            this.unosNovogZaposlenogToolStripMenuItem.Click += new System.EventHandler(this.unosNovogZaposlenogToolStripMenuItem_Click);
            // 
            // brisanjeZaposlenogToolStripMenuItem
            // 
            this.brisanjeZaposlenogToolStripMenuItem.Name = "brisanjeZaposlenogToolStripMenuItem";
            this.brisanjeZaposlenogToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.brisanjeZaposlenogToolStripMenuItem.Text = "Brisanje zaposlenog";
            this.brisanjeZaposlenogToolStripMenuItem.Click += new System.EventHandler(this.brisanjeZaposlenogToolStripMenuItem_Click);
            // 
            // cenovnikToolStripMenuItem
            // 
            this.cenovnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogArtiklaToolStripMenuItem,
            this.pregledArtiklaToolStripMenuItem});
            this.cenovnikToolStripMenuItem.Name = "cenovnikToolStripMenuItem";
            this.cenovnikToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.cenovnikToolStripMenuItem.Text = "Cenovnik";
            // 
            // unosNovogArtiklaToolStripMenuItem
            // 
            this.unosNovogArtiklaToolStripMenuItem.Name = "unosNovogArtiklaToolStripMenuItem";
            this.unosNovogArtiklaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.unosNovogArtiklaToolStripMenuItem.Text = "Unos novog artikla";
            this.unosNovogArtiklaToolStripMenuItem.Click += new System.EventHandler(this.unosNovogArtiklaToolStripMenuItem_Click);
            // 
            // pregledArtiklaToolStripMenuItem
            // 
            this.pregledArtiklaToolStripMenuItem.Name = "pregledArtiklaToolStripMenuItem";
            this.pregledArtiklaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pregledArtiklaToolStripMenuItem.Text = "Brisanje artikla";
            this.pregledArtiklaToolStripMenuItem.Click += new System.EventHandler(this.pregledArtiklaToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 27);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1294, 604);
            this.pnlMain.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 631);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Kasa, konobar:";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dnevniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZaposleniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cenovnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogArtiklaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledArtiklaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem unosNovogZaposlenogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeZaposlenogToolStripMenuItem;
    }
}