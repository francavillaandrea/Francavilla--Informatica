namespace Mediateca
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSoci = new System.Windows.Forms.TabPage();
            this.tabPageMedia = new System.Windows.Forms.TabPage();
            this.tabPageOperazioni = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabControlMain.SuspendLayout();
            this.tabPageSoci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageSoci);
            this.tabControlMain.Controls.Add(this.tabPageMedia);
            this.tabControlMain.Controls.Add(this.tabPageOperazioni);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(818, 450);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageSoci
            // 
            this.tabPageSoci.Controls.Add(this.dgv);
            this.tabPageSoci.Location = new System.Drawing.Point(4, 22);
            this.tabPageSoci.Name = "tabPageSoci";
            this.tabPageSoci.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSoci.Size = new System.Drawing.Size(810, 424);
            this.tabPageSoci.TabIndex = 0;
            this.tabPageSoci.Text = "Soci";
            this.tabPageSoci.UseVisualStyleBackColor = true;
            // 
            // tabPageMedia
            // 
            this.tabPageMedia.Location = new System.Drawing.Point(4, 22);
            this.tabPageMedia.Name = "tabPageMedia";
            this.tabPageMedia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedia.Size = new System.Drawing.Size(792, 424);
            this.tabPageMedia.TabIndex = 1;
            this.tabPageMedia.Text = "Media";
            this.tabPageMedia.UseVisualStyleBackColor = true;
            // 
            // tabPageOperazioni
            // 
            this.tabPageOperazioni.Location = new System.Drawing.Point(4, 22);
            this.tabPageOperazioni.Name = "tabPageOperazioni";
            this.tabPageOperazioni.Size = new System.Drawing.Size(792, 424);
            this.tabPageOperazioni.TabIndex = 2;
            this.tabPageOperazioni.Text = "Operazioni";
            this.tabPageOperazioni.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(634, 418);
            this.dgv.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FrmMain";
            this.Text = "Mediateca";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSoci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSoci;
        private System.Windows.Forms.TabPage tabPageMedia;
        private System.Windows.Forms.TabPage tabPageOperazioni;
        private System.Windows.Forms.DataGridView dgv;
    }
}

