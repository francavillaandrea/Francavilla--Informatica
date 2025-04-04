namespace Francavilla_27._02._25
{
    partial class FrmFrancavilla
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
            this.dgvRis = new System.Windows.Forms.DataGridView();
            this.btnCaricaRis = new System.Windows.Forms.Button();
            this.btnPunteggio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRis
            // 
            this.dgvRis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRis.Location = new System.Drawing.Point(13, 13);
            this.dgvRis.Name = "dgvRis";
            this.dgvRis.Size = new System.Drawing.Size(330, 270);
            this.dgvRis.TabIndex = 0;
            // 
            // btnCaricaRis
            // 
            this.btnCaricaRis.Location = new System.Drawing.Point(387, 13);
            this.btnCaricaRis.Name = "btnCaricaRis";
            this.btnCaricaRis.Size = new System.Drawing.Size(161, 39);
            this.btnCaricaRis.TabIndex = 1;
            this.btnCaricaRis.Text = "Carica Risultati";
            this.btnCaricaRis.UseVisualStyleBackColor = true;
            this.btnCaricaRis.Click += new System.EventHandler(this.btnCaricaRis_Click);
            // 
            // btnPunteggio
            // 
            this.btnPunteggio.Location = new System.Drawing.Point(387, 58);
            this.btnPunteggio.Name = "btnPunteggio";
            this.btnPunteggio.Size = new System.Drawing.Size(161, 39);
            this.btnPunteggio.TabIndex = 2;
            this.btnPunteggio.Text = "Calcola Punteggio";
            this.btnPunteggio.UseVisualStyleBackColor = true;
            this.btnPunteggio.Click += new System.EventHandler(this.btnPunteggio_Click);
            // 
            // FrmFrancavilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPunteggio);
            this.Controls.Add(this.btnCaricaRis);
            this.Controls.Add(this.dgvRis);
            this.Name = "FrmFrancavilla";
            this.Text = "Francavilla Andrea 27.02.2025";
            this.Load += new System.EventHandler(this.FrmFrancavilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRis;
        private System.Windows.Forms.Button btnCaricaRis;
        private System.Windows.Forms.Button btnPunteggio;
    }
}

