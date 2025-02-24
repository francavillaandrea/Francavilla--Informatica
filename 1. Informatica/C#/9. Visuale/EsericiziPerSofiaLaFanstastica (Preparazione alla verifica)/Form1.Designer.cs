namespace EsericiziProva
{
    partial class Form1
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
            this.dgvVettoreAusiliario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCaricaSolo1Vettore = new System.Windows.Forms.Button();
            this.btnCaricaVettore = new System.Windows.Forms.Button();
            this.dgvVettore = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCaricaSolo1E0 = new System.Windows.Forms.Button();
            this.btnCaricaSolo1Matrice = new System.Windows.Forms.Button();
            this.btnCaricaMatrice = new System.Windows.Forms.Button();
            this.dgvMatrice = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRicerca = new System.Windows.Forms.Button();
            this.btnMediaDi2Vettori = new System.Windows.Forms.Button();
            this.btnSommaDi2Vettori = new System.Windows.Forms.Button();
            this.btnCopiaVettore = new System.Windows.Forms.Button();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.btnSomma = new System.Windows.Forms.Button();
            this.btnSpeculare = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnColoraSopraDS = new System.Windows.Forms.Button();
            this.btnMediaSopraDS = new System.Windows.Forms.Button();
            this.btnSommaSopraDS = new System.Windows.Forms.Button();
            this.btnColoraSottoDS = new System.Windows.Forms.Button();
            this.btnMediaSottoDS = new System.Windows.Forms.Button();
            this.btnSommaSottoDS = new System.Windows.Forms.Button();
            this.btnColoraSopraDP = new System.Windows.Forms.Button();
            this.btnMediaSopraDP = new System.Windows.Forms.Button();
            this.btnSommaSopraDP = new System.Windows.Forms.Button();
            this.btnColoraSottoDP = new System.Windows.Forms.Button();
            this.btnMediaSottoDP = new System.Windows.Forms.Button();
            this.btnSommaSottoDP = new System.Windows.Forms.Button();
            this.btnColoraDS = new System.Windows.Forms.Button();
            this.btnColoraDP = new System.Windows.Forms.Button();
            this.btnMediaDS = new System.Windows.Forms.Button();
            this.btnMediaDP = new System.Windows.Forms.Button();
            this.btnSommaDS = new System.Windows.Forms.Button();
            this.btnSommaDP = new System.Windows.Forms.Button();
            this.btnSommaMatrice = new System.Windows.Forms.Button();
            this.btnMaxMatrice = new System.Windows.Forms.Button();
            this.btnMediaMatrice = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRicaricaMatrice = new System.Windows.Forms.Button();
            this.btnRicaricaVettore = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVettoreAusiliario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVettore)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrice)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVettoreAusiliario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCaricaSolo1Vettore);
            this.groupBox1.Controls.Add(this.btnCaricaVettore);
            this.groupBox1.Controls.Add(this.dgvVettore);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vettore";
            // 
            // dgvVettoreAusiliario
            // 
            this.dgvVettoreAusiliario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVettoreAusiliario.Location = new System.Drawing.Point(7, 108);
            this.dgvVettoreAusiliario.Name = "dgvVettoreAusiliario";
            this.dgvVettoreAusiliario.Size = new System.Drawing.Size(374, 25);
            this.dgvVettoreAusiliario.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "VettoreAusiliario";
            // 
            // btnCaricaSolo1Vettore
            // 
            this.btnCaricaSolo1Vettore.Location = new System.Drawing.Point(196, 50);
            this.btnCaricaSolo1Vettore.Name = "btnCaricaSolo1Vettore";
            this.btnCaricaSolo1Vettore.Size = new System.Drawing.Size(185, 39);
            this.btnCaricaSolo1Vettore.TabIndex = 4;
            this.btnCaricaSolo1Vettore.Text = "Carica e Visualizza solo 1";
            this.btnCaricaSolo1Vettore.UseVisualStyleBackColor = true;
            // 
            // btnCaricaVettore
            // 
            this.btnCaricaVettore.Location = new System.Drawing.Point(7, 50);
            this.btnCaricaVettore.Name = "btnCaricaVettore";
            this.btnCaricaVettore.Size = new System.Drawing.Size(183, 39);
            this.btnCaricaVettore.TabIndex = 2;
            this.btnCaricaVettore.Text = "Carica e Visualizza Vettore";
            this.btnCaricaVettore.UseVisualStyleBackColor = true;
            // 
            // dgvVettore
            // 
            this.dgvVettore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVettore.Location = new System.Drawing.Point(7, 19);
            this.dgvVettore.Name = "dgvVettore";
            this.dgvVettore.Size = new System.Drawing.Size(374, 25);
            this.dgvVettore.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCaricaSolo1E0);
            this.groupBox2.Controls.Add(this.btnCaricaSolo1Matrice);
            this.groupBox2.Controls.Add(this.btnCaricaMatrice);
            this.groupBox2.Controls.Add(this.dgvMatrice);
            this.groupBox2.Location = new System.Drawing.Point(412, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matrice";
            // 
            // btnCaricaSolo1E0
            // 
            this.btnCaricaSolo1E0.Location = new System.Drawing.Point(274, 241);
            this.btnCaricaSolo1E0.Name = "btnCaricaSolo1E0";
            this.btnCaricaSolo1E0.Size = new System.Drawing.Size(107, 39);
            this.btnCaricaSolo1E0.TabIndex = 3;
            this.btnCaricaSolo1E0.Text = "Carica e Visualizza 0 e 1";
            this.btnCaricaSolo1E0.UseVisualStyleBackColor = true;
            // 
            // btnCaricaSolo1Matrice
            // 
            this.btnCaricaSolo1Matrice.Location = new System.Drawing.Point(140, 241);
            this.btnCaricaSolo1Matrice.Name = "btnCaricaSolo1Matrice";
            this.btnCaricaSolo1Matrice.Size = new System.Drawing.Size(128, 39);
            this.btnCaricaSolo1Matrice.TabIndex = 2;
            this.btnCaricaSolo1Matrice.Text = "Carica e Visualizza solo 1";
            this.btnCaricaSolo1Matrice.UseVisualStyleBackColor = true;
            // 
            // btnCaricaMatrice
            // 
            this.btnCaricaMatrice.Location = new System.Drawing.Point(12, 241);
            this.btnCaricaMatrice.Name = "btnCaricaMatrice";
            this.btnCaricaMatrice.Size = new System.Drawing.Size(122, 39);
            this.btnCaricaMatrice.TabIndex = 1;
            this.btnCaricaMatrice.Text = "Carica e Visualizza Matrice";
            this.btnCaricaMatrice.UseVisualStyleBackColor = true;
            // 
            // dgvMatrice
            // 
            this.dgvMatrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrice.Location = new System.Drawing.Point(12, 19);
            this.dgvMatrice.Name = "dgvMatrice";
            this.dgvMatrice.Size = new System.Drawing.Size(369, 216);
            this.dgvMatrice.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRicerca);
            this.groupBox3.Controls.Add(this.btnMediaDi2Vettori);
            this.groupBox3.Controls.Add(this.btnSommaDi2Vettori);
            this.groupBox3.Controls.Add(this.btnCopiaVettore);
            this.groupBox3.Controls.Add(this.btnOrdina);
            this.groupBox3.Controls.Add(this.btnSomma);
            this.groupBox3.Controls.Add(this.btnSpeculare);
            this.groupBox3.Controls.Add(this.btnMax);
            this.groupBox3.Controls.Add(this.btnMedia);
            this.groupBox3.Location = new System.Drawing.Point(13, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 509);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OperazioniVettore";
            // 
            // btnRicerca
            // 
            this.btnRicerca.Location = new System.Drawing.Point(18, 68);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(83, 42);
            this.btnRicerca.TabIndex = 8;
            this.btnRicerca.Text = "Ricerca Vettore";
            this.btnRicerca.UseVisualStyleBackColor = true;
            // 
            // btnMediaDi2Vettori
            // 
            this.btnMediaDi2Vettori.Location = new System.Drawing.Point(285, 68);
            this.btnMediaDi2Vettori.Name = "btnMediaDi2Vettori";
            this.btnMediaDi2Vettori.Size = new System.Drawing.Size(83, 42);
            this.btnMediaDi2Vettori.TabIndex = 7;
            this.btnMediaDi2Vettori.Text = "Media Di 2 Vettori";
            this.btnMediaDi2Vettori.UseVisualStyleBackColor = true;
            // 
            // btnSommaDi2Vettori
            // 
            this.btnSommaDi2Vettori.Location = new System.Drawing.Point(18, 116);
            this.btnSommaDi2Vettori.Name = "btnSommaDi2Vettori";
            this.btnSommaDi2Vettori.Size = new System.Drawing.Size(83, 42);
            this.btnSommaDi2Vettori.TabIndex = 6;
            this.btnSommaDi2Vettori.Text = "Somma Di 2 Vettori";
            this.btnSommaDi2Vettori.UseVisualStyleBackColor = true;
            // 
            // btnCopiaVettore
            // 
            this.btnCopiaVettore.Location = new System.Drawing.Point(200, 68);
            this.btnCopiaVettore.Name = "btnCopiaVettore";
            this.btnCopiaVettore.Size = new System.Drawing.Size(83, 42);
            this.btnCopiaVettore.TabIndex = 5;
            this.btnCopiaVettore.Text = "Copia Del Vettore";
            this.btnCopiaVettore.UseVisualStyleBackColor = true;
            // 
            // btnOrdina
            // 
            this.btnOrdina.Location = new System.Drawing.Point(107, 68);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(87, 42);
            this.btnOrdina.TabIndex = 4;
            this.btnOrdina.Text = "Ordina Vettore";
            this.btnOrdina.UseVisualStyleBackColor = true;
            // 
            // btnSomma
            // 
            this.btnSomma.Location = new System.Drawing.Point(285, 20);
            this.btnSomma.Name = "btnSomma";
            this.btnSomma.Size = new System.Drawing.Size(87, 42);
            this.btnSomma.TabIndex = 3;
            this.btnSomma.Text = "Somma";
            this.btnSomma.UseVisualStyleBackColor = true;
            // 
            // btnSpeculare
            // 
            this.btnSpeculare.Location = new System.Drawing.Point(196, 20);
            this.btnSpeculare.Name = "btnSpeculare";
            this.btnSpeculare.Size = new System.Drawing.Size(83, 42);
            this.btnSpeculare.TabIndex = 2;
            this.btnSpeculare.Text = "Speculare";
            this.btnSpeculare.UseVisualStyleBackColor = true;
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(107, 20);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(83, 42);
            this.btnMax.TabIndex = 1;
            this.btnMax.Text = "Valore Max";
            this.btnMax.UseVisualStyleBackColor = true;
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(18, 20);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(83, 42);
            this.btnMedia.TabIndex = 0;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnColoraSopraDS);
            this.groupBox4.Controls.Add(this.btnMediaSopraDS);
            this.groupBox4.Controls.Add(this.btnSommaSopraDS);
            this.groupBox4.Controls.Add(this.btnColoraSottoDS);
            this.groupBox4.Controls.Add(this.btnMediaSottoDS);
            this.groupBox4.Controls.Add(this.btnSommaSottoDS);
            this.groupBox4.Controls.Add(this.btnColoraSopraDP);
            this.groupBox4.Controls.Add(this.btnMediaSopraDP);
            this.groupBox4.Controls.Add(this.btnSommaSopraDP);
            this.groupBox4.Controls.Add(this.btnColoraSottoDP);
            this.groupBox4.Controls.Add(this.btnMediaSottoDP);
            this.groupBox4.Controls.Add(this.btnSommaSottoDP);
            this.groupBox4.Controls.Add(this.btnColoraDS);
            this.groupBox4.Controls.Add(this.btnColoraDP);
            this.groupBox4.Controls.Add(this.btnMediaDS);
            this.groupBox4.Controls.Add(this.btnMediaDP);
            this.groupBox4.Controls.Add(this.btnSommaDS);
            this.groupBox4.Controls.Add(this.btnSommaDP);
            this.groupBox4.Controls.Add(this.btnSommaMatrice);
            this.groupBox4.Controls.Add(this.btnMaxMatrice);
            this.groupBox4.Controls.Add(this.btnMediaMatrice);
            this.groupBox4.Location = new System.Drawing.Point(412, 311);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 364);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OperazioniMatrice";
            // 
            // btnColoraSopraDS
            // 
            this.btnColoraSopraDS.Location = new System.Drawing.Point(6, 259);
            this.btnColoraSopraDS.Name = "btnColoraSopraDS";
            this.btnColoraSopraDS.Size = new System.Drawing.Size(83, 42);
            this.btnColoraSopraDS.TabIndex = 27;
            this.btnColoraSopraDS.Text = "Colora Sopra DS";
            this.btnColoraSopraDS.UseVisualStyleBackColor = true;
            // 
            // btnMediaSopraDS
            // 
            this.btnMediaSopraDS.Location = new System.Drawing.Point(274, 211);
            this.btnMediaSopraDS.Name = "btnMediaSopraDS";
            this.btnMediaSopraDS.Size = new System.Drawing.Size(83, 42);
            this.btnMediaSopraDS.TabIndex = 26;
            this.btnMediaSopraDS.Text = "Media Sopra DS";
            this.btnMediaSopraDS.UseVisualStyleBackColor = true;
            // 
            // btnSommaSopraDS
            // 
            this.btnSommaSopraDS.Location = new System.Drawing.Point(181, 211);
            this.btnSommaSopraDS.Name = "btnSommaSopraDS";
            this.btnSommaSopraDS.Size = new System.Drawing.Size(87, 42);
            this.btnSommaSopraDS.TabIndex = 25;
            this.btnSommaSopraDS.Text = "Somma Sopra DS";
            this.btnSommaSopraDS.UseVisualStyleBackColor = true;
            // 
            // btnColoraSottoDS
            // 
            this.btnColoraSottoDS.Location = new System.Drawing.Point(95, 211);
            this.btnColoraSottoDS.Name = "btnColoraSottoDS";
            this.btnColoraSottoDS.Size = new System.Drawing.Size(83, 42);
            this.btnColoraSottoDS.TabIndex = 24;
            this.btnColoraSottoDS.Text = "Colora Sotto DS";
            this.btnColoraSottoDS.UseVisualStyleBackColor = true;
            // 
            // btnMediaSottoDS
            // 
            this.btnMediaSottoDS.Location = new System.Drawing.Point(6, 211);
            this.btnMediaSottoDS.Name = "btnMediaSottoDS";
            this.btnMediaSottoDS.Size = new System.Drawing.Size(83, 42);
            this.btnMediaSottoDS.TabIndex = 23;
            this.btnMediaSottoDS.Text = "Media Sotto DS";
            this.btnMediaSottoDS.UseVisualStyleBackColor = true;
            // 
            // btnSommaSottoDS
            // 
            this.btnSommaSottoDS.Location = new System.Drawing.Point(274, 163);
            this.btnSommaSottoDS.Name = "btnSommaSottoDS";
            this.btnSommaSottoDS.Size = new System.Drawing.Size(83, 42);
            this.btnSommaSottoDS.TabIndex = 22;
            this.btnSommaSottoDS.Text = "Somma Sotto DS";
            this.btnSommaSottoDS.UseVisualStyleBackColor = true;
            // 
            // btnColoraSopraDP
            // 
            this.btnColoraSopraDP.Location = new System.Drawing.Point(181, 163);
            this.btnColoraSopraDP.Name = "btnColoraSopraDP";
            this.btnColoraSopraDP.Size = new System.Drawing.Size(87, 42);
            this.btnColoraSopraDP.TabIndex = 21;
            this.btnColoraSopraDP.Text = "Colora Sopra DP";
            this.btnColoraSopraDP.UseVisualStyleBackColor = true;
            // 
            // btnMediaSopraDP
            // 
            this.btnMediaSopraDP.Location = new System.Drawing.Point(95, 163);
            this.btnMediaSopraDP.Name = "btnMediaSopraDP";
            this.btnMediaSopraDP.Size = new System.Drawing.Size(83, 42);
            this.btnMediaSopraDP.TabIndex = 20;
            this.btnMediaSopraDP.Text = "Media Sopra DP";
            this.btnMediaSopraDP.UseVisualStyleBackColor = true;
            // 
            // btnSommaSopraDP
            // 
            this.btnSommaSopraDP.Location = new System.Drawing.Point(6, 163);
            this.btnSommaSopraDP.Name = "btnSommaSopraDP";
            this.btnSommaSopraDP.Size = new System.Drawing.Size(83, 42);
            this.btnSommaSopraDP.TabIndex = 19;
            this.btnSommaSopraDP.Text = "Somma Sopra DP";
            this.btnSommaSopraDP.UseVisualStyleBackColor = true;
            // 
            // btnColoraSottoDP
            // 
            this.btnColoraSottoDP.Location = new System.Drawing.Point(274, 115);
            this.btnColoraSottoDP.Name = "btnColoraSottoDP";
            this.btnColoraSottoDP.Size = new System.Drawing.Size(87, 42);
            this.btnColoraSottoDP.TabIndex = 18;
            this.btnColoraSottoDP.Text = "Colora Sotto DP";
            this.btnColoraSottoDP.UseVisualStyleBackColor = true;
            // 
            // btnMediaSottoDP
            // 
            this.btnMediaSottoDP.Location = new System.Drawing.Point(181, 115);
            this.btnMediaSottoDP.Name = "btnMediaSottoDP";
            this.btnMediaSottoDP.Size = new System.Drawing.Size(87, 42);
            this.btnMediaSottoDP.TabIndex = 17;
            this.btnMediaSottoDP.Text = "Media Sotto DP";
            this.btnMediaSottoDP.UseVisualStyleBackColor = true;
            // 
            // btnSommaSottoDP
            // 
            this.btnSommaSottoDP.Location = new System.Drawing.Point(95, 115);
            this.btnSommaSottoDP.Name = "btnSommaSottoDP";
            this.btnSommaSottoDP.Size = new System.Drawing.Size(83, 42);
            this.btnSommaSottoDP.TabIndex = 16;
            this.btnSommaSottoDP.Text = "Somma Sotto DP";
            this.btnSommaSottoDP.UseVisualStyleBackColor = true;
            // 
            // btnColoraDS
            // 
            this.btnColoraDS.Location = new System.Drawing.Point(6, 115);
            this.btnColoraDS.Name = "btnColoraDS";
            this.btnColoraDS.Size = new System.Drawing.Size(83, 42);
            this.btnColoraDS.TabIndex = 15;
            this.btnColoraDS.Text = "Colora DS";
            this.btnColoraDS.UseVisualStyleBackColor = true;
            // 
            // btnColoraDP
            // 
            this.btnColoraDP.Location = new System.Drawing.Point(95, 67);
            this.btnColoraDP.Name = "btnColoraDP";
            this.btnColoraDP.Size = new System.Drawing.Size(83, 42);
            this.btnColoraDP.TabIndex = 14;
            this.btnColoraDP.Text = "Colora DP";
            this.btnColoraDP.UseVisualStyleBackColor = true;
            // 
            // btnMediaDS
            // 
            this.btnMediaDS.Location = new System.Drawing.Point(274, 67);
            this.btnMediaDS.Name = "btnMediaDS";
            this.btnMediaDS.Size = new System.Drawing.Size(87, 42);
            this.btnMediaDS.TabIndex = 13;
            this.btnMediaDS.Text = "Media DS";
            this.btnMediaDS.UseVisualStyleBackColor = true;
            // 
            // btnMediaDP
            // 
            this.btnMediaDP.Location = new System.Drawing.Point(6, 67);
            this.btnMediaDP.Name = "btnMediaDP";
            this.btnMediaDP.Size = new System.Drawing.Size(83, 42);
            this.btnMediaDP.TabIndex = 12;
            this.btnMediaDP.Text = "Media DP";
            this.btnMediaDP.UseVisualStyleBackColor = true;
            // 
            // btnSommaDS
            // 
            this.btnSommaDS.Location = new System.Drawing.Point(181, 67);
            this.btnSommaDS.Name = "btnSommaDS";
            this.btnSommaDS.Size = new System.Drawing.Size(87, 42);
            this.btnSommaDS.TabIndex = 11;
            this.btnSommaDS.Text = "Somma DS";
            this.btnSommaDS.UseVisualStyleBackColor = true;
            // 
            // btnSommaDP
            // 
            this.btnSommaDP.Location = new System.Drawing.Point(274, 19);
            this.btnSommaDP.Name = "btnSommaDP";
            this.btnSommaDP.Size = new System.Drawing.Size(87, 42);
            this.btnSommaDP.TabIndex = 10;
            this.btnSommaDP.Text = "Somma DP";
            this.btnSommaDP.UseVisualStyleBackColor = true;
            // 
            // btnSommaMatrice
            // 
            this.btnSommaMatrice.Location = new System.Drawing.Point(181, 19);
            this.btnSommaMatrice.Name = "btnSommaMatrice";
            this.btnSommaMatrice.Size = new System.Drawing.Size(87, 42);
            this.btnSommaMatrice.TabIndex = 9;
            this.btnSommaMatrice.Text = "Somma";
            this.btnSommaMatrice.UseVisualStyleBackColor = true;
            // 
            // btnMaxMatrice
            // 
            this.btnMaxMatrice.Location = new System.Drawing.Point(95, 19);
            this.btnMaxMatrice.Name = "btnMaxMatrice";
            this.btnMaxMatrice.Size = new System.Drawing.Size(83, 42);
            this.btnMaxMatrice.TabIndex = 9;
            this.btnMaxMatrice.Text = "Valore Max";
            this.btnMaxMatrice.UseVisualStyleBackColor = true;
            // 
            // btnMediaMatrice
            // 
            this.btnMediaMatrice.Location = new System.Drawing.Point(6, 19);
            this.btnMediaMatrice.Name = "btnMediaMatrice";
            this.btnMediaMatrice.Size = new System.Drawing.Size(83, 42);
            this.btnMediaMatrice.TabIndex = 9;
            this.btnMediaMatrice.Text = "Media";
            this.btnMediaMatrice.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRicaricaMatrice);
            this.groupBox5.Controls.Add(this.btnRicaricaVettore);
            this.groupBox5.Location = new System.Drawing.Point(806, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(163, 118);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reset";
            // 
            // btnRicaricaMatrice
            // 
            this.btnRicaricaMatrice.Location = new System.Drawing.Point(7, 64);
            this.btnRicaricaMatrice.Name = "btnRicaricaMatrice";
            this.btnRicaricaMatrice.Size = new System.Drawing.Size(150, 39);
            this.btnRicaricaMatrice.TabIndex = 1;
            this.btnRicaricaMatrice.Text = "Ricarica Matrice";
            this.btnRicaricaMatrice.UseVisualStyleBackColor = true;
            // 
            // btnRicaricaVettore
            // 
            this.btnRicaricaVettore.Location = new System.Drawing.Point(7, 19);
            this.btnRicaricaVettore.Name = "btnRicaricaVettore";
            this.btnRicaricaVettore.Size = new System.Drawing.Size(150, 39);
            this.btnRicaricaVettore.TabIndex = 0;
            this.btnRicaricaVettore.Text = "Ricarica Vettore";
            this.btnRicaricaVettore.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 687);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "VettoriMatrici";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVettoreAusiliario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVettore)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrice)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVettore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMatrice;
        private System.Windows.Forms.Button btnCaricaVettore;
        private System.Windows.Forms.Button btnCaricaSolo1E0;
        private System.Windows.Forms.Button btnCaricaSolo1Matrice;
        private System.Windows.Forms.Button btnCaricaMatrice;
        private System.Windows.Forms.Button btnCaricaSolo1Vettore;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnMediaDi2Vettori;
        private System.Windows.Forms.Button btnSommaDi2Vettori;
        private System.Windows.Forms.Button btnCopiaVettore;
        private System.Windows.Forms.Button btnOrdina;
        private System.Windows.Forms.Button btnSomma;
        private System.Windows.Forms.Button btnSpeculare;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.DataGridView dgvVettoreAusiliario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRicaricaMatrice;
        private System.Windows.Forms.Button btnRicaricaVettore;
        private System.Windows.Forms.Button btnColoraDP;
        private System.Windows.Forms.Button btnMediaDS;
        private System.Windows.Forms.Button btnMediaDP;
        private System.Windows.Forms.Button btnSommaDS;
        private System.Windows.Forms.Button btnSommaDP;
        private System.Windows.Forms.Button btnSommaMatrice;
        private System.Windows.Forms.Button btnMaxMatrice;
        private System.Windows.Forms.Button btnMediaMatrice;
        private System.Windows.Forms.Button btnColoraDS;
        private System.Windows.Forms.Button btnMediaSopraDS;
        private System.Windows.Forms.Button btnSommaSopraDS;
        private System.Windows.Forms.Button btnColoraSottoDS;
        private System.Windows.Forms.Button btnMediaSottoDS;
        private System.Windows.Forms.Button btnSommaSottoDS;
        private System.Windows.Forms.Button btnColoraSopraDP;
        private System.Windows.Forms.Button btnMediaSopraDP;
        private System.Windows.Forms.Button btnSommaSopraDP;
        private System.Windows.Forms.Button btnColoraSottoDP;
        private System.Windows.Forms.Button btnMediaSottoDP;
        private System.Windows.Forms.Button btnSommaSottoDP;
        private System.Windows.Forms.Button btnColoraSopraDS;
    }
}

