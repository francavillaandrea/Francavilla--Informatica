namespace Forza4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblGiocatore.Size = new System.Drawing.Size(178, 24);
            this.lblGiocatore.TabIndex = 0;
            this.lblGiocatore.Text = "[lblGiocatore]";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(17, 49);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Size = new System.Drawing.Size(468, 343);
            this.dgv.TabIndex = 1;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btnGioca
            // 
            this.btnGioca.BackColor = System.Drawing.Color.Coral;
            this.btnGioca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGioca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGioca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGioca.Location = new System.Drawing.Point(17, 398);
            this.btnGioca.Name = "btnGioca";
            this.btnGioca.Size = new System.Drawing.Size(122, 46);
            this.btnGioca.TabIndex = 2;
            this.btnGioca.Text = "GIOCA";
            this.btnGioca.UseVisualStyleBackColor = false;
            this.btnGioca.Click += new System.EventHandler(this.btnGioca_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 467);
            this.Controls.Add(this.btnGioca);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblGiocatore);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forza4";
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

