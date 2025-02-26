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
            this.btnOrdinaStudentiCognomeNome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRicercaBinariaMatricola = new System.Windows.Forms.Button();
            this.btnCercaClassePiùStudenti = new System.Windows.Forms.Button();
            this.btnContaStudentiClasse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvValutazioni = new System.Windows.Forms.DataGridView();
            this.btnCaricaValutazioni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValutazioni)).BeginInit();
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
            this.dgvStudenti.Location = new System.Drawing.Point(12, 47);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.Size = new System.Drawing.Size(446, 150);
            this.dgvStudenti.TabIndex = 1;
            // 
            // btnOrdinaStudentiCognomeNome
            // 
            this.btnOrdinaStudentiCognomeNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdinaStudentiCognomeNome.Location = new System.Drawing.Point(17, 19);
            this.btnOrdinaStudentiCognomeNome.Name = "btnOrdinaStudentiCognomeNome";
            this.btnOrdinaStudentiCognomeNome.Size = new System.Drawing.Size(163, 42);
            this.btnOrdinaStudentiCognomeNome.TabIndex = 2;
            this.btnOrdinaStudentiCognomeNome.Text = "ORDINA STUDENTI NOMINATIVO";
            this.btnOrdinaStudentiCognomeNome.UseVisualStyleBackColor = true;
            this.btnOrdinaStudentiCognomeNome.Click += new System.EventHandler(this.btnOrdinaStudentiCognomeNome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRicercaBinariaMatricola);
            this.groupBox1.Controls.Add(this.btnCercaClassePiùStudenti);
            this.groupBox1.Controls.Add(this.btnContaStudentiClasse);
            this.groupBox1.Controls.Add(this.btnOrdinaStudentiCognomeNome);
            this.groupBox1.Location = new System.Drawing.Point(464, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 208);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // btnRicercaBinariaMatricola
            // 
            this.btnRicercaBinariaMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRicercaBinariaMatricola.Location = new System.Drawing.Point(17, 160);
            this.btnRicercaBinariaMatricola.Name = "btnRicercaBinariaMatricola";
            this.btnRicercaBinariaMatricola.Size = new System.Drawing.Size(163, 42);
            this.btnRicercaBinariaMatricola.TabIndex = 5;
            this.btnRicercaBinariaMatricola.Text = "RICERCA BINARIA MATRICOLA";
            this.btnRicercaBinariaMatricola.UseVisualStyleBackColor = true;
            this.btnRicercaBinariaMatricola.Click += new System.EventHandler(this.btnRicercaBinariaMatricola_Click);
            // 
            // btnCercaClassePiùStudenti
            // 
            this.btnCercaClassePiùStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCercaClassePiùStudenti.Location = new System.Drawing.Point(17, 115);
            this.btnCercaClassePiùStudenti.Name = "btnCercaClassePiùStudenti";
            this.btnCercaClassePiùStudenti.Size = new System.Drawing.Size(163, 42);
            this.btnCercaClassePiùStudenti.TabIndex = 4;
            this.btnCercaClassePiùStudenti.Text = "CERCA CLASSE CON + STUDENTI";
            this.btnCercaClassePiùStudenti.UseVisualStyleBackColor = true;
            this.btnCercaClassePiùStudenti.Click += new System.EventHandler(this.btnCercaClassePiùStudenti_Click);
            // 
            // btnContaStudentiClasse
            // 
            this.btnContaStudentiClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContaStudentiClasse.Location = new System.Drawing.Point(17, 67);
            this.btnContaStudentiClasse.Name = "btnContaStudentiClasse";
            this.btnContaStudentiClasse.Size = new System.Drawing.Size(163, 42);
            this.btnContaStudentiClasse.TabIndex = 3;
            this.btnContaStudentiClasse.Text = "CONTA STUDENTI CLASSE";
            this.btnContaStudentiClasse.UseVisualStyleBackColor = true;
            this.btnContaStudentiClasse.Click += new System.EventHandler(this.btnContaStudentiClasse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(1162, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 208);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Query";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "RICERCA BINARIA MATRICOLA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(17, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "CERCA CLASSE CON + STUDENTI";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(17, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "CONTA STUDENTI CLASSE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(17, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 42);
            this.button4.TabIndex = 2;
            this.button4.Text = "ORDINA STUDENTI NOMINATIVO";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dgvValutazioni
            // 
            this.dgvValutazioni.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvValutazioni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvValutazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValutazioni.Location = new System.Drawing.Point(710, 47);
            this.dgvValutazioni.Name = "dgvValutazioni";
            this.dgvValutazioni.Size = new System.Drawing.Size(446, 150);
            this.dgvValutazioni.TabIndex = 5;
            // 
            // btnCaricaValutazioni
            // 
            this.btnCaricaValutazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaricaValutazioni.Location = new System.Drawing.Point(710, 12);
            this.btnCaricaValutazioni.Name = "btnCaricaValutazioni";
            this.btnCaricaValutazioni.Size = new System.Drawing.Size(163, 23);
            this.btnCaricaValutazioni.TabIndex = 4;
            this.btnCaricaValutazioni.Text = "CARICA VALUTAZIONI";
            this.btnCaricaValutazioni.UseVisualStyleBackColor = true;
            this.btnCaricaValutazioni.Click += new System.EventHandler(this.btnCaricaValutazioni_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvValutazioni);
            this.Controls.Add(this.btnCaricaValutazioni);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.btnCaricaTabellaStudenti);
            this.Name = "frmMain";
            this.Text = "Gestione Tabella";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValutazioni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaricaTabellaStudenti;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Button btnOrdinaStudentiCognomeNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnContaStudentiClasse;
        private System.Windows.Forms.Button btnCercaClassePiùStudenti;
        private System.Windows.Forms.Button btnRicercaBinariaMatricola;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvValutazioni;
        private System.Windows.Forms.Button btnCaricaValutazioni;
    }
}

