namespace RegistroElettronico
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cmbMaterie = new System.Windows.Forms.ComboBox();
            this.btnCalcolaMediaMat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1221, 705);
            this.dgv.TabIndex = 0;
            // 
            // cmbMaterie
            // 
            this.cmbMaterie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterie.FormattingEnabled = true;
            this.cmbMaterie.Location = new System.Drawing.Point(1248, 12);
            this.cmbMaterie.Name = "cmbMaterie";
            this.cmbMaterie.Size = new System.Drawing.Size(156, 32);
            this.cmbMaterie.TabIndex = 1;
            // 
            // btnCalcolaMediaMat
            // 
            this.btnCalcolaMediaMat.Location = new System.Drawing.Point(1248, 50);
            this.btnCalcolaMediaMat.Name = "btnCalcolaMediaMat";
            this.btnCalcolaMediaMat.Size = new System.Drawing.Size(156, 46);
            this.btnCalcolaMediaMat.TabIndex = 2;
            this.btnCalcolaMediaMat.Text = "MEDIA MAT.";
            this.btnCalcolaMediaMat.UseVisualStyleBackColor = true;
            this.btnCalcolaMediaMat.Click += new System.EventHandler(this.btnCalcolaMediaMat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 729);
            this.Controls.Add(this.btnCalcolaMediaMat);
            this.Controls.Add(this.cmbMaterie);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO ELETTRONICO";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cmbMaterie;
        private System.Windows.Forms.Button btnCalcolaMediaMat;
    }
}

