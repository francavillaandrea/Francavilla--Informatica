namespace VettoriMatriciVisuale
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
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.btnMaxVettore = new System.Windows.Forms.Button();
            this.btnCalcolaMediaVettore = new System.Windows.Forms.Button();
            this.btnCercaElementoVettore = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnSpeulare = new System.Windows.Forms.Button();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrimi3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv1Addendo = new System.Windows.Forms.DataGridView();
            this.dgv2Addendo = new System.Windows.Forms.DataGridView();
            this.dgvSomma = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSomma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1Addendo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2Addendo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSomma)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvA
            // 
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(38, 39);
            this.dgvA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvA.Name = "dgvA";
            this.dgvA.Size = new System.Drawing.Size(426, 60);
            this.dgvA.TabIndex = 0;
            // 
            // btnMaxVettore
            // 
            this.btnMaxVettore.Location = new System.Drawing.Point(38, 134);
            this.btnMaxVettore.Name = "btnMaxVettore";
            this.btnMaxVettore.Size = new System.Drawing.Size(75, 53);
            this.btnMaxVettore.TabIndex = 1;
            this.btnMaxVettore.Text = "Cercare il MAX del vettore";
            this.btnMaxVettore.UseVisualStyleBackColor = true;
            this.btnMaxVettore.Click += new System.EventHandler(this.btnMaxVettore_Click);
            // 
            // btnCalcolaMediaVettore
            // 
            this.btnCalcolaMediaVettore.Location = new System.Drawing.Point(119, 134);
            this.btnCalcolaMediaVettore.Name = "btnCalcolaMediaVettore";
            this.btnCalcolaMediaVettore.Size = new System.Drawing.Size(75, 53);
            this.btnCalcolaMediaVettore.TabIndex = 2;
            this.btnCalcolaMediaVettore.Text = "Calcolare la MEDIA vettore";
            this.btnCalcolaMediaVettore.UseVisualStyleBackColor = true;
            this.btnCalcolaMediaVettore.Click += new System.EventHandler(this.btnCalcolaMediaVettore_Click);
            // 
            // btnCercaElementoVettore
            // 
            this.btnCercaElementoVettore.Location = new System.Drawing.Point(58, 16);
            this.btnCercaElementoVettore.Name = "btnCercaElementoVettore";
            this.btnCercaElementoVettore.Size = new System.Drawing.Size(75, 53);
            this.btnCercaElementoVettore.TabIndex = 4;
            this.btnCercaElementoVettore.Text = "Cercare elemento vettore";
            this.btnCercaElementoVettore.UseVisualStyleBackColor = true;
            this.btnCercaElementoVettore.Click += new System.EventHandler(this.btnCercaElementoVettore_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.btnCercaElementoVettore);
            this.groupBox1.Location = new System.Drawing.Point(200, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(6, 16);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(34, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // btnSpeulare
            // 
            this.btnSpeulare.Location = new System.Drawing.Point(356, 134);
            this.btnSpeulare.Name = "btnSpeulare";
            this.btnSpeulare.Size = new System.Drawing.Size(89, 53);
            this.btnSpeulare.TabIndex = 6;
            this.btnSpeulare.Text = "Verificare se vettore SPECULARE";
            this.btnSpeulare.UseVisualStyleBackColor = true;
            this.btnSpeulare.Click += new System.EventHandler(this.btnSpeulare_Click);
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(86, 19);
            this.dgv3.Name = "dgv3";
            this.dgv3.Size = new System.Drawing.Size(81, 34);
            this.dgv3.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrimi3);
            this.groupBox2.Controls.Add(this.dgv3);
            this.groupBox2.Location = new System.Drawing.Point(465, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 97);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MASSIMI";
            // 
            // btnPrimi3
            // 
            this.btnPrimi3.Location = new System.Drawing.Point(6, 19);
            this.btnPrimi3.Name = "btnPrimi3";
            this.btnPrimi3.Size = new System.Drawing.Size(75, 63);
            this.btnPrimi3.TabIndex = 8;
            this.btnPrimi3.Text = "Cerca 3 MASSIMI vettore";
            this.btnPrimi3.UseVisualStyleBackColor = true;
            this.btnPrimi3.Click += new System.EventHandler(this.btnPrimi3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSomma);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dgvSomma);
            this.groupBox3.Controls.Add(this.dgv2Addendo);
            this.groupBox3.Controls.Add(this.dgv1Addendo);
            this.groupBox3.Location = new System.Drawing.Point(668, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 192);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SOMMA VETTORI";
            // 
            // dgv1Addendo
            // 
            this.dgv1Addendo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1Addendo.Location = new System.Drawing.Point(17, 26);
            this.dgv1Addendo.Name = "dgv1Addendo";
            this.dgv1Addendo.Size = new System.Drawing.Size(81, 34);
            this.dgv1Addendo.TabIndex = 8;
            // 
            // dgv2Addendo
            // 
            this.dgv2Addendo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2Addendo.Location = new System.Drawing.Point(17, 77);
            this.dgv2Addendo.Name = "dgv2Addendo";
            this.dgv2Addendo.Size = new System.Drawing.Size(81, 34);
            this.dgv2Addendo.TabIndex = 9;
            // 
            // dgvSomma
            // 
            this.dgvSomma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSomma.Location = new System.Drawing.Point(17, 136);
            this.dgvSomma.Name = "dgvSomma";
            this.dgvSomma.Size = new System.Drawing.Size(81, 34);
            this.dgvSomma.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "-----------";
            // 
            // btnSomma
            // 
            this.btnSomma.Location = new System.Drawing.Point(106, 111);
            this.btnSomma.Name = "btnSomma";
            this.btnSomma.Size = new System.Drawing.Size(75, 63);
            this.btnSomma.TabIndex = 14;
            this.btnSomma.Text = "SOMMA Vettori";
            this.btnSomma.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 265);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSpeulare);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcolaMediaVettore);
            this.Controls.Add(this.btnMaxVettore);
            this.Controls.Add(this.dgvA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Text = "Vettori e Matrici in Visuale";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1Addendo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2Addendo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSomma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.Button btnMaxVettore;
        private System.Windows.Forms.Button btnCalcolaMediaVettore;
        private System.Windows.Forms.Button btnCercaElementoVettore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnSpeulare;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrimi3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSomma;
        private System.Windows.Forms.DataGridView dgv2Addendo;
        private System.Windows.Forms.DataGridView dgv1Addendo;
        private System.Windows.Forms.Button btnSomma;
    }
}

