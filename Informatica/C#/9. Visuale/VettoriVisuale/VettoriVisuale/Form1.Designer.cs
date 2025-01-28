namespace VettoriMatriciVisuale
{
    partial class frmMain
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
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.btnMaxVettore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvA
            // 
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(38, 39);
            this.dgvA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvA.Name = "dgvA";
            this.dgvA.Size = new System.Drawing.Size(426, 60);
            this.dgvA.TabIndex = 0;
            // 
            // btnMaxVettore
            // 
            this.btnMaxVettore.Location = new System.Drawing.Point(38, 123);
            this.btnMaxVettore.Name = "btnMaxVettore";
            this.btnMaxVettore.Size = new System.Drawing.Size(75, 53);
            this.btnMaxVettore.TabIndex = 1;
            this.btnMaxVettore.Text = "Cercare il MAX del vettore";
            this.btnMaxVettore.UseVisualStyleBackColor = true;
            this.btnMaxVettore.Click += new System.EventHandler(this.btnMaxVettore_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 188);
            this.Controls.Add(this.btnMaxVettore);
            this.Controls.Add(this.dgvA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Text = "Vettori e Matrici in Visuale";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.Button btnMaxVettore;
    }
}

