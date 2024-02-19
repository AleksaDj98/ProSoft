namespace View.Forms
{
    partial class FrmDnevniIzvestaj
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
            this.btnIzvestaj = new System.Windows.Forms.Button();
            this.dtpDnevniIzvestaj = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnIzvestaj
            // 
            this.btnIzvestaj.Location = new System.Drawing.Point(67, 152);
            this.btnIzvestaj.Name = "btnIzvestaj";
            this.btnIzvestaj.Size = new System.Drawing.Size(276, 70);
            this.btnIzvestaj.TabIndex = 0;
            this.btnIzvestaj.Text = "Dnevni izvestaj";
            this.btnIzvestaj.UseVisualStyleBackColor = true;
            this.btnIzvestaj.Click += new System.EventHandler(this.btnIzvestaj_Click);
            // 
            // dtpDnevniIzvestaj
            // 
            this.dtpDnevniIzvestaj.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDnevniIzvestaj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDnevniIzvestaj.Location = new System.Drawing.Point(81, 71);
            this.dtpDnevniIzvestaj.Name = "dtpDnevniIzvestaj";
            this.dtpDnevniIzvestaj.Size = new System.Drawing.Size(262, 22);
            this.dtpDnevniIzvestaj.TabIndex = 1;
            // 
            // FrmDnevniIzvestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 303);
            this.Controls.Add(this.dtpDnevniIzvestaj);
            this.Controls.Add(this.btnIzvestaj);
            this.Name = "FrmDnevniIzvestaj";
            this.Text = "FrmDnevniIzvestaj";
            this.Load += new System.EventHandler(this.FrmDnevniIzvestaj_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzvestaj;
        private System.Windows.Forms.DateTimePicker dtpDnevniIzvestaj;
    }
}