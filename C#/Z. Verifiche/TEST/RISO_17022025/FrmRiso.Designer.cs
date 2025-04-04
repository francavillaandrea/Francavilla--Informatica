namespace RISO_17022025
{
    partial class FrmRiso
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGioca = new System.Windows.Forms.Button();
            this.btnMain1 = new System.Windows.Forms.Button();
            this.btnMain2 = new System.Windows.Forms.Button();
            this.btnMain3 = new System.Windows.Forms.Button();
            this.btnMain4 = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgv.Location = new System.Drawing.Point(12, 49);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 79;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv.Size = new System.Drawing.Size(318, 399);
            this.dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MASTERMIND";
            // 
            // btnGioca
            // 
            this.btnGioca.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGioca.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGioca.Location = new System.Drawing.Point(240, 6);
            this.btnGioca.Name = "btnGioca";
            this.btnGioca.Size = new System.Drawing.Size(90, 34);
            this.btnGioca.TabIndex = 2;
            this.btnGioca.Text = "GIOCA";
            this.btnGioca.UseVisualStyleBackColor = false;
            this.btnGioca.Click += new System.EventHandler(this.btnGioca_Click);
            // 
            // btnMain1
            // 
            this.btnMain1.Enabled = false;
            this.btnMain1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMain1.Location = new System.Drawing.Point(12, 454);
            this.btnMain1.Name = "btnMain1";
            this.btnMain1.Size = new System.Drawing.Size(75, 70);
            this.btnMain1.TabIndex = 3;
            this.btnMain1.Text = "1";
            this.btnMain1.UseVisualStyleBackColor = true;
            this.btnMain1.Click += new System.EventHandler(this.btnMain1_Click);
            // 
            // btnMain2
            // 
            this.btnMain2.Enabled = false;
            this.btnMain2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMain2.Location = new System.Drawing.Point(93, 454);
            this.btnMain2.Name = "btnMain2";
            this.btnMain2.Size = new System.Drawing.Size(75, 70);
            this.btnMain2.TabIndex = 4;
            this.btnMain2.Text = "1";
            this.btnMain2.UseVisualStyleBackColor = true;
            this.btnMain2.Click += new System.EventHandler(this.btnMain2_Click);
            // 
            // btnMain3
            // 
            this.btnMain3.Enabled = false;
            this.btnMain3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMain3.Location = new System.Drawing.Point(174, 454);
            this.btnMain3.Name = "btnMain3";
            this.btnMain3.Size = new System.Drawing.Size(75, 70);
            this.btnMain3.TabIndex = 5;
            this.btnMain3.Text = "1";
            this.btnMain3.UseVisualStyleBackColor = true;
            this.btnMain3.Click += new System.EventHandler(this.btnMain3_Click);
            // 
            // btnMain4
            // 
            this.btnMain4.Enabled = false;
            this.btnMain4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMain4.Location = new System.Drawing.Point(255, 454);
            this.btnMain4.Name = "btnMain4";
            this.btnMain4.Size = new System.Drawing.Size(75, 70);
            this.btnMain4.TabIndex = 6;
            this.btnMain4.Text = "1";
            this.btnMain4.UseVisualStyleBackColor = true;
            this.btnMain4.Click += new System.EventHandler(this.btnMain4_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTest.Enabled = false;
            this.btnTest.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnTest.Location = new System.Drawing.Point(12, 530);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(318, 67);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "VERIFICA";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // FrmRiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 609);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnMain4);
            this.Controls.Add(this.btnMain3);
            this.Controls.Add(this.btnMain2);
            this.Controls.Add(this.btnMain1);
            this.Controls.Add(this.btnGioca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRiso";
            this.Text = "Riso";
            this.Load += new System.EventHandler(this.FrmRiso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGioca;
        private System.Windows.Forms.Button btnMain1;
        private System.Windows.Forms.Button btnMain2;
        private System.Windows.Forms.Button btnMain3;
        private System.Windows.Forms.Button btnMain4;
        private System.Windows.Forms.Button btnTest;
    }
}

