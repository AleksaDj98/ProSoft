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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dnevniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodicniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogRadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cenovnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogArtiklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledArtiklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izvestajiToolStripMenuItem,
            this.unosNovogRadnikaToolStripMenuItem,
            this.cenovnikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1573, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dnevniToolStripMenuItem,
            this.periodicniToolStripMenuItem});
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.izvestajiToolStripMenuItem.Text = "Izvestaji";
            // 
            // dnevniToolStripMenuItem
            // 
            this.dnevniToolStripMenuItem.Name = "dnevniToolStripMenuItem";
            this.dnevniToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.dnevniToolStripMenuItem.Text = "Dnevni";
            // 
            // periodicniToolStripMenuItem
            // 
            this.periodicniToolStripMenuItem.Name = "periodicniToolStripMenuItem";
            this.periodicniToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.periodicniToolStripMenuItem.Text = "Periodicni";
            // 
            // unosNovogRadnikaToolStripMenuItem
            // 
            this.unosNovogRadnikaToolStripMenuItem.Name = "unosNovogRadnikaToolStripMenuItem";
            this.unosNovogRadnikaToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.unosNovogRadnikaToolStripMenuItem.Text = "Unos novog radnika";
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
            // 
            // pregledArtiklaToolStripMenuItem
            // 
            this.pregledArtiklaToolStripMenuItem.Name = "pregledArtiklaToolStripMenuItem";
            this.pregledArtiklaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pregledArtiklaToolStripMenuItem.Text = "Pregled artikla";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 33);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1573, 730);
            this.pnlMain.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 761);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "Kasa, konobar:";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dnevniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodicniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogRadnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cenovnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogArtiklaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledArtiklaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Panel pnlMain;
    }
}