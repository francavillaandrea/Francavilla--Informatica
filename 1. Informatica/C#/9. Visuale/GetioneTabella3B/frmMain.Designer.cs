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
            this.cmbMaterieDinamica = new System.Windows.Forms.ComboBox();
            this.cmbMaterieStatica = new System.Windows.Forms.ComboBox();
            this.btnCercaMateriaPiùVoti = new System.Windows.Forms.Button();
            this.btnMediaValutazioniMateria = new System.Windows.Forms.Button();
            this.btnCalcolaMediaValutazioniMateria = new System.Windows.Forms.Button();
            this.dgvValutazioni = new System.Windows.Forms.DataGridView();
            this.btnCaricaValutazioni = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCalcolaMediaStudenteClic = new System.Windows.Forms.Button();
            this.cmbMatricole = new System.Windows.Forms.ComboBox();
            this.btnCalcolaMediaStudenteCombo = new System.Windows.Forms.Button();
            this.btnCalcolaMediaStudente = new System.Windows.Forms.Button();
            this.btnInserisciStudente = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbClassi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeStudente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognomeStudente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValutazioni)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.dgvStudenti.Size = new System.Drawing.Size(367, 150);
            this.dgvStudenti.TabIndex = 1;
            this.dgvStudenti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenti_CellClick);
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
            this.groupBox1.Location = new System.Drawing.Point(410, 12);
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
            this.groupBox2.Controls.Add(this.cmbMaterieDinamica);
            this.groupBox2.Controls.Add(this.cmbMaterieStatica);
            this.groupBox2.Controls.Add(this.btnCercaMateriaPiùVoti);
            this.groupBox2.Controls.Add(this.btnMediaValutazioniMateria);
            this.groupBox2.Controls.Add(this.btnCalcolaMediaValutazioniMateria);
            this.groupBox2.Location = new System.Drawing.Point(1027, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 168);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Query";
            // 
            // cmbMaterieDinamica
            // 
            this.cmbMaterieDinamica.FormattingEnabled = true;
            this.cmbMaterieDinamica.Location = new System.Drawing.Point(6, 67);
            this.cmbMaterieDinamica.Name = "cmbMaterieDinamica";
            this.cmbMaterieDinamica.Size = new System.Drawing.Size(108, 21);
            this.cmbMaterieDinamica.TabIndex = 7;
            // 
            // cmbMaterieStatica
            // 
            this.cmbMaterieStatica.FormattingEnabled = true;
            this.cmbMaterieStatica.Items.AddRange(new object[] {
            "ITA",
            "STO",
            "INF",
            "ING"});
            this.cmbMaterieStatica.Location = new System.Drawing.Point(6, 19);
            this.cmbMaterieStatica.Name = "cmbMaterieStatica";
            this.cmbMaterieStatica.Size = new System.Drawing.Size(108, 21);
            this.cmbMaterieStatica.TabIndex = 6;
            // 
            // btnCercaMateriaPiùVoti
            // 
            this.btnCercaMateriaPiùVoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCercaMateriaPiùVoti.Location = new System.Drawing.Point(120, 115);
            this.btnCercaMateriaPiùVoti.Name = "btnCercaMateriaPiùVoti";
            this.btnCercaMateriaPiùVoti.Size = new System.Drawing.Size(163, 42);
            this.btnCercaMateriaPiùVoti.TabIndex = 4;
            this.btnCercaMateriaPiùVoti.Text = "CERCA MATERIA CON + VOTI";
            this.btnCercaMateriaPiùVoti.UseVisualStyleBackColor = true;
            this.btnCercaMateriaPiùVoti.Click += new System.EventHandler(this.btnCercaMateriaPiùVoti_Click);
            // 
            // btnMediaValutazioniMateria
            // 
            this.btnMediaValutazioniMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaValutazioniMateria.Location = new System.Drawing.Point(120, 67);
            this.btnMediaValutazioniMateria.Name = "btnMediaValutazioniMateria";
            this.btnMediaValutazioniMateria.Size = new System.Drawing.Size(163, 42);
            this.btnMediaValutazioniMateria.TabIndex = 3;
            this.btnMediaValutazioniMateria.Text = "CALCOLA MEDIA VALUTAZIONI MATERIA";
            this.btnMediaValutazioniMateria.UseVisualStyleBackColor = true;
            this.btnMediaValutazioniMateria.Click += new System.EventHandler(this.btnMediaValutazioniMateria_Click);
            // 
            // btnCalcolaMediaValutazioniMateria
            // 
            this.btnCalcolaMediaValutazioniMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcolaMediaValutazioniMateria.Location = new System.Drawing.Point(120, 19);
            this.btnCalcolaMediaValutazioniMateria.Name = "btnCalcolaMediaValutazioniMateria";
            this.btnCalcolaMediaValutazioniMateria.Size = new System.Drawing.Size(163, 42);
            this.btnCalcolaMediaValutazioniMateria.TabIndex = 2;
            this.btnCalcolaMediaValutazioniMateria.Text = "CALCOLA MEDIA VALUTAZIONI MATERIA";
            this.btnCalcolaMediaValutazioniMateria.UseVisualStyleBackColor = true;
            this.btnCalcolaMediaValutazioniMateria.Click += new System.EventHandler(this.btnCalcolaMediaValutazioniMateria_Click);
            // 
            // dgvValutazioni
            // 
            this.dgvValutazioni.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvValutazioni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvValutazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValutazioni.Location = new System.Drawing.Point(641, 47);
            this.dgvValutazioni.Name = "dgvValutazioni";
            this.dgvValutazioni.Size = new System.Drawing.Size(343, 150);
            this.dgvValutazioni.TabIndex = 5;
            // 
            // btnCaricaValutazioni
            // 
            this.btnCaricaValutazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaricaValutazioni.Location = new System.Drawing.Point(641, 12);
            this.btnCaricaValutazioni.Name = "btnCaricaValutazioni";
            this.btnCaricaValutazioni.Size = new System.Drawing.Size(163, 23);
            this.btnCaricaValutazioni.TabIndex = 4;
            this.btnCaricaValutazioni.Text = "CARICA VALUTAZIONI";
            this.btnCaricaValutazioni.UseVisualStyleBackColor = true;
            this.btnCaricaValutazioni.Click += new System.EventHandler(this.btnCaricaValutazioni_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCalcolaMediaStudenteClic);
            this.groupBox3.Controls.Add(this.cmbMatricole);
            this.groupBox3.Controls.Add(this.btnCalcolaMediaStudenteCombo);
            this.groupBox3.Controls.Add(this.btnCalcolaMediaStudente);
            this.groupBox3.Location = new System.Drawing.Point(1033, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 198);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Query comuni";
            // 
            // btnCalcolaMediaStudenteClic
            // 
            this.btnCalcolaMediaStudenteClic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcolaMediaStudenteClic.Location = new System.Drawing.Point(114, 115);
            this.btnCalcolaMediaStudenteClic.Name = "btnCalcolaMediaStudenteClic";
            this.btnCalcolaMediaStudenteClic.Size = new System.Drawing.Size(163, 42);
            this.btnCalcolaMediaStudenteClic.TabIndex = 9;
            this.btnCalcolaMediaStudenteClic.Text = "CALCOLA MEDIA STUDENTE CLIC";
            this.btnCalcolaMediaStudenteClic.UseVisualStyleBackColor = true;
            this.btnCalcolaMediaStudenteClic.Click += new System.EventHandler(this.btnCalcolaMediaStudenteClic_Click);
            // 
            // cmbMatricole
            // 
            this.cmbMatricole.FormattingEnabled = true;
            this.cmbMatricole.Location = new System.Drawing.Point(0, 67);
            this.cmbMatricole.Name = "cmbMatricole";
            this.cmbMatricole.Size = new System.Drawing.Size(108, 21);
            this.cmbMatricole.TabIndex = 8;
            // 
            // btnCalcolaMediaStudenteCombo
            // 
            this.btnCalcolaMediaStudenteCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcolaMediaStudenteCombo.Location = new System.Drawing.Point(114, 67);
            this.btnCalcolaMediaStudenteCombo.Name = "btnCalcolaMediaStudenteCombo";
            this.btnCalcolaMediaStudenteCombo.Size = new System.Drawing.Size(163, 42);
            this.btnCalcolaMediaStudenteCombo.TabIndex = 6;
            this.btnCalcolaMediaStudenteCombo.Text = "CALCOLA MEDIA STUDENTE COMBO";
            this.btnCalcolaMediaStudenteCombo.UseVisualStyleBackColor = true;
            this.btnCalcolaMediaStudenteCombo.Click += new System.EventHandler(this.btnCalcolaMediaStudenteCombo_Click);
            // 
            // btnCalcolaMediaStudente
            // 
            this.btnCalcolaMediaStudente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcolaMediaStudente.Location = new System.Drawing.Point(114, 19);
            this.btnCalcolaMediaStudente.Name = "btnCalcolaMediaStudente";
            this.btnCalcolaMediaStudente.Size = new System.Drawing.Size(163, 42);
            this.btnCalcolaMediaStudente.TabIndex = 5;
            this.btnCalcolaMediaStudente.Text = "CALCOLA MEDIA STUDENTE";
            this.btnCalcolaMediaStudente.UseVisualStyleBackColor = true;
            this.btnCalcolaMediaStudente.Click += new System.EventHandler(this.btnCalcolaMediaStudente_Click);
            // 
            // btnInserisciStudente
            // 
            this.btnInserisciStudente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserisciStudente.Location = new System.Drawing.Point(18, 113);
            this.btnInserisciStudente.Name = "btnInserisciStudente";
            this.btnInserisciStudente.Size = new System.Drawing.Size(166, 42);
            this.btnInserisciStudente.TabIndex = 8;
            this.btnInserisciStudente.Text = "INSERISCI STUDENTE";
            this.btnInserisciStudente.UseVisualStyleBackColor = true;
            this.btnInserisciStudente.Click += new System.EventHandler(this.btnInserisciStudente_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbClassi);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtNomeStudente);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtCognomeStudente);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnInserisciStudente);
            this.groupBox4.Location = new System.Drawing.Point(12, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 173);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Info Studente";
            // 
            // cmbClassi
            // 
            this.cmbClassi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassi.FormattingEnabled = true;
            this.cmbClassi.Location = new System.Drawing.Point(84, 86);
            this.cmbClassi.Name = "cmbClassi";
            this.cmbClassi.Size = new System.Drawing.Size(100, 21);
            this.cmbClassi.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "CLASSE";
            // 
            // txtNomeStudente
            // 
            this.txtNomeStudente.Location = new System.Drawing.Point(84, 53);
            this.txtNomeStudente.Name = "txtNomeStudente";
            this.txtNomeStudente.Size = new System.Drawing.Size(100, 20);
            this.txtNomeStudente.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "NOME";
            // 
            // txtCognomeStudente
            // 
            this.txtCognomeStudente.Location = new System.Drawing.Point(84, 21);
            this.txtCognomeStudente.Name = "txtCognomeStudente";
            this.txtCognomeStudente.Size = new System.Drawing.Size(100, 20);
            this.txtCognomeStudente.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "COGNOME";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 510);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvValutazioni);
            this.Controls.Add(this.btnCaricaValutazioni);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.btnCaricaTabellaStudenti);
            this.Name = "frmMain";
            this.Text = "Gestione Tabella";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValutazioni)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Button btnCercaMateriaPiùVoti;
        private System.Windows.Forms.Button btnMediaValutazioniMateria;
        private System.Windows.Forms.Button btnCalcolaMediaValutazioniMateria;
        private System.Windows.Forms.DataGridView dgvValutazioni;
        private System.Windows.Forms.Button btnCaricaValutazioni;
        private System.Windows.Forms.ComboBox cmbMaterieStatica;
        private System.Windows.Forms.ComboBox cmbMaterieDinamica;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCalcolaMediaStudente;
        private System.Windows.Forms.ComboBox cmbMatricole;
        private System.Windows.Forms.Button btnCalcolaMediaStudenteCombo;
        private System.Windows.Forms.Button btnCalcolaMediaStudenteClic;
        private System.Windows.Forms.Button btnInserisciStudente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbClassi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeStudente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCognomeStudente;
        private System.Windows.Forms.Label label1;
    }
}

