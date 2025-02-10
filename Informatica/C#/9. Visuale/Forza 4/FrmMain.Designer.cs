namespace Forza_4
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
            this.lblGiocatore = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnGioca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGiocatore
            // 
            this.lblGiocatore.AutoSize = true;
            this.lblGiocatore.Location = new System.Drawing.Point(13, 13);
            this.lblGiocatore.Name = "lblGiocatore";
            this.lblGiocatore.Size = new System.Drawing.Size(69, 13);
            this.lblGiocatore.TabIndex = 0;
            this.lblGiocatore.Text = "[lblGiocatore]";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(16, 42);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(369, 281);
            this.dgv.TabIndex = 1;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btnGioca
            // 
            this.btnGioca.BackColor = System.Drawing.Color.Transparent;
            this.btnGioca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioca.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGioca.Location = new System.Drawing.Point(16, 357);
            this.btnGioca.Name = "btnGioca";
            this.btnGioca.Size = new System.Drawing.Size(122, 39);
            this.btnGioca.TabIndex = 2;
            this.btnGioca.Text = "GIOCA";
            this.btnGioca.UseVisualStyleBackColor = false;
            this.btnGioca.Click += new System.EventHandler(this.btnGioca_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 422);
            this.Controls.Add(this.btnGioca);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblGiocatore);
            this.Name = "FrmMain";
            this.Text = "Forza 4";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGiocatore;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnGioca;
    }
}

