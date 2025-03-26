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
            this.tabPageOperazioni = new System.Windows.Forms.TabPage();
            this.btnSalvaSocio = new System.Windows.Forms.Button();
            this.btnAnnullaSocio = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageSoci.SuspendLayout();
            this.groupBoxSoci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).BeginInit();
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
            this.groupBoxSoci.Location = new System.Drawing.Point(592, 16);
            this.groupBoxSoci.Name = "groupBoxSoci";
            this.groupBoxSoci.Size = new System.Drawing.Size(215, 400);
            this.groupBoxSoci.TabIndex = 1;
            this.groupBoxSoci.TabStop = false;
            this.groupBoxSoci.Text = "Comandi";
            // 
            // btnModificaSocio
            // 
            this.btnModificaSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaSocio.Location = new System.Drawing.Point(21, 272);
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
            this.btnCancellaSocio.Location = new System.Drawing.Point(21, 235);
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
            this.btnInserisciSocio.Location = new System.Drawing.Point(21, 198);
            this.btnInserisciSocio.Name = "btnInserisciSocio";
            this.btnInserisciSocio.Size = new System.Drawing.Size(188, 31);
            this.btnInserisciSocio.TabIndex = 8;
            this.btnInserisciSocio.Text = "INSERISCI SOCIO";
            this.btnInserisciSocio.UseVisualStyleBackColor = true;
            this.btnInserisciSocio.Click += new System.EventHandler(this.btnInserisciSocio_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(93, 156);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(116, 23);
            this.txtTelefono.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(116, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "eMail";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(93, 75);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(116, 23);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(93, 32);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(116, 23);
            this.txtCognome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cognome";
            // 
            // dgvSoci
            // 
            this.dgvSoci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoci.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvSoci.Location = new System.Drawing.Point(3, 3);
            this.dgvSoci.Name = "dgvSoci";
            this.dgvSoci.Size = new System.Drawing.Size(583, 418);
            this.dgvSoci.TabIndex = 0;
            // 
            // tabPageMedia
            // 
            this.tabPageMedia.Location = new System.Drawing.Point(4, 22);
            this.tabPageMedia.Name = "tabPageMedia";
            this.tabPageMedia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedia.Size = new System.Drawing.Size(792, 424);
            this.tabPageMedia.TabIndex = 0;
            this.tabPageMedia.Text = "MEDIA";
            this.tabPageMedia.UseVisualStyleBackColor = true;
            // 
            // tabPageOperazioni
            // 
            this.tabPageOperazioni.Location = new System.Drawing.Point(4, 22);
            this.tabPageOperazioni.Name = "tabPageOperazioni";
            this.tabPageOperazioni.Size = new System.Drawing.Size(792, 424);
            this.tabPageOperazioni.TabIndex = 2;
            this.tabPageOperazioni.Text = "OPERAZIONI";
            this.tabPageOperazioni.UseVisualStyleBackColor = true;
            // 
            // btnSalvaSocio
            // 
            this.btnSalvaSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaSocio.Location = new System.Drawing.Point(21, 309);
            this.btnSalvaSocio.Name = "btnSalvaSocio";
            this.btnSalvaSocio.Size = new System.Drawing.Size(89, 31);
            this.btnSalvaSocio.TabIndex = 11;
            this.btnSalvaSocio.Text = "SALVA";
            this.btnSalvaSocio.UseVisualStyleBackColor = true;
            this.btnSalvaSocio.Click += new System.EventHandler(this.btnSalvaSocio_Click);
            // 
            // btnAnnullaSocio
            // 
            this.btnAnnullaSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnullaSocio.Location = new System.Drawing.Point(116, 309);
            this.btnAnnullaSocio.Name = "btnAnnullaSocio";
            this.btnAnnullaSocio.Size = new System.Drawing.Size(93, 31);
            this.btnAnnullaSocio.TabIndex = 12;
            this.btnAnnullaSocio.Text = "ANNULLA";
            this.btnAnnullaSocio.UseVisualStyleBackColor = true;
            this.btnAnnullaSocio.Click += new System.EventHandler(this.btnAnnullaSocio_Click);
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
    }
}

