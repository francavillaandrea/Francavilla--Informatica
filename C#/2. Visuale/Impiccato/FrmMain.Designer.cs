namespace Impiccato
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtParolaSegreta = new System.Windows.Forms.TextBox();
            this.btnAvvia = new System.Windows.Forms.Button();
            this.gbPartita = new System.Windows.Forms.GroupBox();
            this.txtLettera = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.gbPartita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAvvia);
            this.groupBox1.Controls.Add(this.txtParolaSegreta);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserisci Parola Segreta:";
            // 
            // txtParolaSegreta
            // 
            this.txtParolaSegreta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParolaSegreta.Location = new System.Drawing.Point(7, 32);
            this.txtParolaSegreta.Name = "txtParolaSegreta";
            this.txtParolaSegreta.Size = new System.Drawing.Size(319, 32);
            this.txtParolaSegreta.TabIndex = 0;
            this.txtParolaSegreta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAvvia
            // 
            this.btnAvvia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvvia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvvia.ForeColor = System.Drawing.Color.Red;
            this.btnAvvia.Location = new System.Drawing.Point(332, 31);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(144, 33);
            this.btnAvvia.TabIndex = 1;
            this.btnAvvia.Text = "Gioca";
            this.btnAvvia.UseVisualStyleBackColor = true;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click);
            // 
            // gbPartita
            // 
            this.gbPartita.Controls.Add(this.lblOutput);
            this.gbPartita.Controls.Add(this.btnVerifica);
            this.gbPartita.Controls.Add(this.txtLettera);
            this.gbPartita.Location = new System.Drawing.Point(13, 101);
            this.gbPartita.Name = "gbPartita";
            this.gbPartita.Size = new System.Drawing.Size(489, 259);
            this.gbPartita.TabIndex = 1;
            this.gbPartita.TabStop = false;
            this.gbPartita.Text = "Partita:";
            this.gbPartita.Visible = false;
            // 
            // txtLettera
            // 
            this.txtLettera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLettera.Location = new System.Drawing.Point(7, 31);
            this.txtLettera.MaxLength = 1;
            this.txtLettera.Name = "txtLettera";
            this.txtLettera.Size = new System.Drawing.Size(100, 32);
            this.txtLettera.TabIndex = 0;
            this.txtLettera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifica.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnVerifica.Location = new System.Drawing.Point(113, 31);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(157, 32);
            this.btnVerifica.TabIndex = 1;
            this.btnVerifica.Text = "Tenta";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.Tomato;
            this.lblOutput.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.Snow;
            this.lblOutput.Location = new System.Drawing.Point(6, 89);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(179, 37);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "RISULTATO";
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(508, 13);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(458, 347);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 379);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.gbPartita);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMPICCATO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPartita.ResumeLayout(false);
            this.gbPartita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAvvia;
        private System.Windows.Forms.TextBox txtParolaSegreta;
        private System.Windows.Forms.GroupBox gbPartita;
        private System.Windows.Forms.TextBox txtLettera;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.PictureBox pic;
    }
}

