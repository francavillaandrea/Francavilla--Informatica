namespace Mediateca
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSoci = new System.Windows.Forms.TabPage();
            this.groupBoxSoci = new System.Windows.Forms.GroupBox();
            this.btnAnnullaSocio = new System.Windows.Forms.Button();
            this.btnSalvaSocio = new System.Windows.Forms.Button();
            this.btnModificaSocio = new System.Windows.Forms.Button();
            this.btnCancellaSocio = new System.Windows.Forms.Button();
            this.btnInserisciSocio = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSoci = new System.Windows.Forms.DataGridView();
            this.tabPageMedia = new System.Windows.Forms.TabPage();
            this.groupBoxMedia = new System.Windows.Forms.GroupBox();
            this.cmbGenere = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnAnnullaMedia = new System.Windows.Forms.Button();
            this.btnSalvaMedia = new System.Windows.Forms.Button();
            this.btnModificaMedia = new System.Windows.Forms.Button();
            this.btnCancellaMedia = new System.Windows.Forms.Button();
            this.btnInserisciMedia = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvMedia = new System.Windows.Forms.DataGridView();
            this.tabPageOperazioni = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabPageSoci.SuspendLayout();
            this.groupBoxSoci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).BeginInit();
            this.tabPageMedia.SuspendLayout();
            this.groupBoxMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).BeginInit();
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
            this.tabControlMain.Size = new System.Drawing.Size(823, 450);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageSoci
            // 
            this.tabPageSoci.Controls.Add(this.groupBoxSoci);
            this.tabPageSoci.Controls.Add(this.dgvSoci);
            this.tabPageSoci.Location = new System.Drawing.Point(4, 22);
            this.tabPageSoci.Name = "tabPageSoci";
            this.tabPageSoci.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSoci.Size = new System.Drawing.Size(815, 424);
            this.tabPageSoci.TabIndex = 1;
            this.tabPageSoci.Text = "SOCI";
            this.tabPageSoci.UseVisualStyleBackColor = true;
            // 
            // groupBoxSoci
            // 
            this.groupBoxSoci.Controls.Add(this.btnAnnullaSocio);
            this.groupBoxSoci.Controls.Add(this.btnSalvaSocio);
            this.groupBoxSoci.Controls.Add(this.btnModificaSocio);
            this.groupBoxSoci.Controls.Add(this.btnCancellaSocio);
            this.groupBoxSoci.Controls.Add(this.btnInserisciSocio);
            this.groupBoxSoci.Controls.Add(this.txtTelefono);
            this.groupBoxSoci.Controls.Add(this.label4);
            this.groupBoxSoci.Controls.Add(this.txtEmail);
            this.groupBoxSoci.Controls.Add(this.label3);
            this.groupBoxSoci.Controls.Add(this.txtNome);
            this.groupBoxSoci.Controls.Add(this.label2);
            this.groupBoxSoci.Controls.Add(this.txtCognome);
            this.groupBoxSoci.Controls.Add(this.label1);
            this.groupBoxSoci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSoci.Location = new System.Drawing.Point(592, 3);
            this.groupBoxSoci.Name = "groupBoxSoci";
            this.groupBoxSoci.Size = new System.Drawing.Size(215, 413);
            this.groupBoxSoci.TabIndex = 1;
            this.groupBoxSoci.TabStop = false;
            this.groupBoxSoci.Text = "Comandi e Query";
            // 
            // btnAnnullaSocio
            // 
            this.btnAnnullaSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnullaSocio.Location = new System.Drawing.Point(112, 258);
            this.btnAnnullaSocio.Name = "btnAnnullaSocio";
            this.btnAnnullaSocio.Size = new System.Drawing.Size(93, 31);
            this.btnAnnullaSocio.TabIndex = 12;
            this.btnAnnullaSocio.Text = "ANNULLA";
            this.btnAnnullaSocio.UseVisualStyleBackColor = true;
            this.btnAnnullaSocio.Click += new System.EventHandler(this.btnAnnullaSocio_Click);
            // 
            // btnSalvaSocio
            // 
            this.btnSalvaSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaSocio.Location = new System.Drawing.Point(17, 258);
            this.btnSalvaSocio.Name = "btnSalvaSocio";
            this.btnSalvaSocio.Size = new System.Drawing.Size(89, 31);
            this.btnSalvaSocio.TabIndex = 11;
            this.btnSalvaSocio.Text = "SALVA";
            this.btnSalvaSocio.UseVisualStyleBackColor = true;
            this.btnSalvaSocio.Click += new System.EventHandler(this.btnSalvaSocio_Click);
            // 
            // btnModificaSocio
            // 
            this.btnModificaSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaSocio.Location = new System.Drawing.Point(17, 221);
            this.btnModificaSocio.Name = "btnModificaSocio";
            this.btnModificaSocio.Size = new System.Drawing.Size(188, 31);
            this.btnModificaSocio.TabIndex = 10;
            this.btnModificaSocio.Text = "MODIFICA SOCIO";
            this.btnModificaSocio.UseVisualStyleBackColor = true;
            this.btnModificaSocio.Click += new System.EventHandler(this.btnModificaSocio_Click);
            // 
            // btnCancellaSocio
            // 
            this.btnCancellaSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancellaSocio.Location = new System.Drawing.Point(17, 184);
            this.btnCancellaSocio.Name = "btnCancellaSocio";
            this.btnCancellaSocio.Size = new System.Drawing.Size(188, 31);
            this.btnCancellaSocio.TabIndex = 9;
            this.btnCancellaSocio.Text = "CANCELLA SOCIO";
            this.btnCancellaSocio.UseVisualStyleBackColor = true;
            this.btnCancellaSocio.Click += new System.EventHandler(this.btnCancellaSocio_Click);
            // 
            // btnInserisciSocio
            // 
            this.btnInserisciSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserisciSocio.Location = new System.Drawing.Point(17, 147);
            this.btnInserisciSocio.Name = "btnInserisciSocio";
            this.btnInserisciSocio.Size = new System.Drawing.Size(188, 31);
            this.btnInserisciSocio.TabIndex = 8;
            this.btnInserisciSocio.Text = "INSERISCI SOCIO";
            this.btnInserisciSocio.UseVisualStyleBackColor = true;
            this.btnInserisciSocio.Click += new System.EventHandler(this.btnInserisciSocio_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(89, 115);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(116, 23);
            this.txtTelefono.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(89, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(116, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "eMail";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(116, 23);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(89, 28);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(116, 23);
            this.txtCognome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cognome";
            // 
            // dgvSoci
            // 
            this.dgvSoci.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSoci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSoci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoci.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvSoci.Location = new System.Drawing.Point(3, 3);
            this.dgvSoci.Name = "dgvSoci";
            this.dgvSoci.Size = new System.Drawing.Size(583, 418);
            this.dgvSoci.TabIndex = 0;
            // 
            // tabPageMedia
            // 
            this.tabPageMedia.Controls.Add(this.groupBoxMedia);
            this.tabPageMedia.Controls.Add(this.dgvMedia);
            this.tabPageMedia.Location = new System.Drawing.Point(4, 22);
            this.tabPageMedia.Name = "tabPageMedia";
            this.tabPageMedia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedia.Size = new System.Drawing.Size(815, 424);
            this.tabPageMedia.TabIndex = 0;
            this.tabPageMedia.Text = "MEDIA";
            this.tabPageMedia.UseVisualStyleBackColor = true;
            // 
            // groupBoxMedia
            // 
            this.groupBoxMedia.Controls.Add(this.cmbGenere);
            this.groupBoxMedia.Controls.Add(this.cmbTipo);
            this.groupBoxMedia.Controls.Add(this.btnAnnullaMedia);
            this.groupBoxMedia.Controls.Add(this.btnSalvaMedia);
            this.groupBoxMedia.Controls.Add(this.btnModificaMedia);
            this.groupBoxMedia.Controls.Add(this.btnCancellaMedia);
            this.groupBoxMedia.Controls.Add(this.btnInserisciMedia);
            this.groupBoxMedia.Controls.Add(this.label5);
            this.groupBoxMedia.Controls.Add(this.label6);
            this.groupBoxMedia.Controls.Add(this.txtAutore);
            this.groupBoxMedia.Controls.Add(this.label7);
            this.groupBoxMedia.Controls.Add(this.txtTitolo);
            this.groupBoxMedia.Controls.Add(this.label8);
            this.groupBoxMedia.Location = new System.Drawing.Point(595, 7);
            this.groupBoxMedia.Name = "groupBoxMedia";
            this.groupBoxMedia.Size = new System.Drawing.Size(212, 409);
            this.groupBoxMedia.TabIndex = 1;
            this.groupBoxMedia.TabStop = false;
            this.groupBoxMedia.Text = "Comandi e Query";
            // 
            // cmbGenere
            // 
            this.cmbGenere.FormattingEnabled = true;
            this.cmbGenere.Location = new System.Drawing.Point(81, 110);
            this.cmbGenere.Name = "cmbGenere";
            this.cmbGenere.Size = new System.Drawing.Size(116, 21);
            this.cmbGenere.TabIndex = 27;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(81, 78);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(116, 21);
            this.cmbTipo.TabIndex = 26;
            // 
            // btnAnnullaMedia
            // 
            this.btnAnnullaMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnullaMedia.Location = new System.Drawing.Point(104, 248);
            this.btnAnnullaMedia.Name = "btnAnnullaMedia";
            this.btnAnnullaMedia.Size = new System.Drawing.Size(93, 31);
            this.btnAnnullaMedia.TabIndex = 25;
            this.btnAnnullaMedia.Text = "ANNULLA";
            this.btnAnnullaMedia.UseVisualStyleBackColor = true;
            // 
            // btnSalvaMedia
            // 
            this.btnSalvaMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaMedia.Location = new System.Drawing.Point(9, 248);
            this.btnSalvaMedia.Name = "btnSalvaMedia";
            this.btnSalvaMedia.Size = new System.Drawing.Size(89, 31);
            this.btnSalvaMedia.TabIndex = 24;
            this.btnSalvaMedia.Text = "SALVA";
            this.btnSalvaMedia.UseVisualStyleBackColor = true;
            // 
            // btnModificaMedia
            // 
            this.btnModificaMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaMedia.Location = new System.Drawing.Point(9, 211);
            this.btnModificaMedia.Name = "btnModificaMedia";
            this.btnModificaMedia.Size = new System.Drawing.Size(188, 31);
            this.btnModificaMedia.TabIndex = 23;
            this.btnModificaMedia.Text = "MODIFICA MEDIA";
            this.btnModificaMedia.UseVisualStyleBackColor = true;
            // 
            // btnCancellaMedia
            // 
            this.btnCancellaMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancellaMedia.Location = new System.Drawing.Point(9, 174);
            this.btnCancellaMedia.Name = "btnCancellaMedia";
            this.btnCancellaMedia.Size = new System.Drawing.Size(188, 31);
            this.btnCancellaMedia.TabIndex = 22;
            this.btnCancellaMedia.Text = "CANCELLA MEDIA";
            this.btnCancellaMedia.UseVisualStyleBackColor = true;
            // 
            // btnInserisciMedia
            // 
            this.btnInserisciMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserisciMedia.Location = new System.Drawing.Point(9, 137);
            this.btnInserisciMedia.Name = "btnInserisciMedia";
            this.btnInserisciMedia.Size = new System.Drawing.Size(188, 31);
            this.btnInserisciMedia.TabIndex = 21;
            this.btnInserisciMedia.Text = "INSERISCI MEDIA";
            this.btnInserisciMedia.UseVisualStyleBackColor = true;
            this.btnInserisciMedia.Click += new System.EventHandler(this.btnInserisciMedia_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Genere";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tipo";
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(81, 47);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(116, 20);
            this.txtAutore.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Autore";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(81, 18);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(116, 20);
            this.txtTitolo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Titolo";
            // 
            // dgvMedia
            // 
            this.dgvMedia.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMedia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedia.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvMedia.Location = new System.Drawing.Point(3, 3);
            this.dgvMedia.Name = "dgvMedia";
            this.dgvMedia.Size = new System.Drawing.Size(585, 418);
            this.dgvMedia.TabIndex = 0;
            // 
            // tabPageOperazioni
            // 
            this.tabPageOperazioni.Location = new System.Drawing.Point(4, 22);
            this.tabPageOperazioni.Name = "tabPageOperazioni";
            this.tabPageOperazioni.Size = new System.Drawing.Size(815, 424);
            this.tabPageOperazioni.TabIndex = 2;
            this.tabPageOperazioni.Text = "OPERAZIONI";
            this.tabPageOperazioni.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "frmMain";
            this.Text = "MEDIATECA";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSoci.ResumeLayout(false);
            this.groupBoxSoci.ResumeLayout(false);
            this.groupBoxSoci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).EndInit();
            this.tabPageMedia.ResumeLayout(false);
            this.groupBoxMedia.ResumeLayout(false);
            this.groupBoxMedia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSoci;
        private System.Windows.Forms.DataGridView dgvSoci;
        private System.Windows.Forms.TabPage tabPageMedia;
        private System.Windows.Forms.TabPage tabPageOperazioni;
        private System.Windows.Forms.GroupBox groupBoxSoci;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserisciSocio;
        private System.Windows.Forms.Button btnCancellaSocio;
        private System.Windows.Forms.Button btnModificaSocio;
        private System.Windows.Forms.Button btnAnnullaSocio;
        private System.Windows.Forms.Button btnSalvaSocio;
        private System.Windows.Forms.DataGridView dgvMedia;
        private System.Windows.Forms.GroupBox groupBoxMedia;
        private System.Windows.Forms.Button btnAnnullaMedia;
        private System.Windows.Forms.Button btnSalvaMedia;
        private System.Windows.Forms.Button btnModificaMedia;
        private System.Windows.Forms.Button btnCancellaMedia;
        private System.Windows.Forms.Button btnInserisciMedia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGenere;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}

