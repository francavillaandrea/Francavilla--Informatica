namespace BattagliaNavale
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(13, 13);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(556, 128);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(323, 166);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(37, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Testo:";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(300, 249);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(94, 31);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "INIZIA";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click_1);
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(701, 292);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.dgv1);
            this.Name = "FrmMain";
            this.Text = "Battaglia Navale";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnStartGame;
    }
}

