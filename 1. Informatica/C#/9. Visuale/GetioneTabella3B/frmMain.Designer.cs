namespace GetioneTabella3B
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
            this.btnCaricaTabellaStudenti = new System.Windows.Forms.Button();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.btn_ordina = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_RicercaClasse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCaricaTabellaStudenti
            // 
            this.btnCaricaTabellaStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaricaTabellaStudenti.Location = new System.Drawing.Point(12, 12);
            this.btnCaricaTabellaStudenti.Name = "btnCaricaTabellaStudenti";
            this.btnCaricaTabellaStudenti.Size = new System.Drawing.Size(163, 23);
            this.btnCaricaTabellaStudenti.TabIndex = 0;
            this.btnCaricaTabellaStudenti.Text = "CARICA STUDENTI";
            this.btnCaricaTabellaStudenti.UseVisualStyleBackColor = true;
            this.btnCaricaTabellaStudenti.Click += new System.EventHandler(this.btnCaricaTabellaStudenti_Click);
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStudenti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(12, 56);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.Size = new System.Drawing.Size(446, 150);
            this.dgvStudenti.TabIndex = 1;
            // 
            // btn_ordina
            // 
            this.btn_ordina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ordina.Location = new System.Drawing.Point(21, 19);
            this.btn_ordina.Name = "btn_ordina";
            this.btn_ordina.Size = new System.Drawing.Size(163, 45);
            this.btn_ordina.TabIndex = 2;
            this.btn_ordina.Text = "ORDINA STUDENTI PER NOMINATIVO";
            this.btn_ordina.UseVisualStyleBackColor = true;
            this.btn_ordina.Click += new System.EventHandler(this.btn_ordina_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_RicercaClasse);
            this.groupBox1.Controls.Add(this.btn_ordina);
            this.groupBox1.Location = new System.Drawing.Point(588, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 194);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // btn_RicercaClasse
            // 
            this.btn_RicercaClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RicercaClasse.Location = new System.Drawing.Point(21, 70);
            this.btn_RicercaClasse.Name = "btn_RicercaClasse";
            this.btn_RicercaClasse.Size = new System.Drawing.Size(163, 49);
            this.btn_RicercaClasse.TabIndex = 3;
            this.btn_RicercaClasse.Text = "CONTA STUDENTI CLASSE";
            this.btn_RicercaClasse.UseVisualStyleBackColor = true;
            this.btn_RicercaClasse.Click += new System.EventHandler(this.btn_RicercaClasse_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.btnCaricaTabellaStudenti);
            this.Name = "frmMain";
            this.Text = "Gestione Tabella";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaricaTabellaStudenti;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Button btn_ordina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_RicercaClasse;
    }
}

