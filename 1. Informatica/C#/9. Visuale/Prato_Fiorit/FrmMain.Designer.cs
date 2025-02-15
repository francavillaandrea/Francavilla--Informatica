namespace Prato_Fiorit
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.lblGameStatus);
            this.Controls.Add(this.dgvGameBoard);
            this.Controls.Add(this.btnNewGame);
            this.Text = "Minesweeper";
        }

            // 
            // lblGameStatus
            // 
            this.lblGameStatus = new System.Windows.Forms.Label();
            this.lblGameStatus.AutoSize = true;
            this.lblGameStatus.Location = new System.Drawing.Point(20, 20);
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(100, 20);
            this.lblGameStatus.TabIndex = 0;
            this.lblGameStatus.Text = "Game Status";

            // 
            // dgvGameBoard
            // 
            this.dgvGameBoard = new System.Windows.Forms.DataGridView();
            this.dgvGameBoard.AllowUserToAddRows = false;
            this.dgvGameBoard.AllowUserToDeleteRows = false;
            this.dgvGameBoard.AllowUserToResizeColumns = false;
            this.dgvGameBoard.AllowUserToResizeRows = false;
            this.dgvGameBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGameBoard.ColumnHeadersVisible = false;
            this.dgvGameBoard.Location = new System.Drawing.Point(20, 50);
            this.dgvGameBoard.Name = "dgvGameBoard";
            this.dgvGameBoard.RowHeadersVisible = false;
            this.dgvGameBoard.RowTemplate.Height = 25;
            this.dgvGameBoard.Size = new System.Drawing.Size(360, 360);
            this.dgvGameBoard.TabIndex = 1;

            // 
            // btnNewGame
            // 
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnNewGame.Location = new System.Drawing.Point(150, 430);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(100, 30);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;

        #endregion

        private System.Windows.Forms.Label lblGameStatus;
        private System.Windows.Forms.DataGridView dgvGameBoard;
        private System.Windows.Forms.Button btnNewGame;

        private System.Windows.Forms.Label lblGameStatus;
        private System.Windows.Forms.DataGridView dgvGameBoard;
        private System.Windows.Forms.Button btnNewGame;
    }
}