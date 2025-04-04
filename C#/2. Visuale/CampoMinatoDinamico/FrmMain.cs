using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampoMinatoDinamico
{
    public partial class FrmMain : Form
    {
        static Random rnd = new Random(); 
        int[,] m; // Matrice di controllo
        int cntVittoria; // Contatore pulsanti "gioco" cliccati 
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "CAMPO MINATO";
            disegnaDifficolta();
        }

        private void disegnaDifficolta()
        {
            Label lbl = new Label();
            ComboBox cmb = new ComboBox();
            string[] vDiff = { "FACILE: 10x10", "MEDIO: 20x20", 
                               "DIFFICILE: 30x30" };
            Button btn = new Button(); 

            lbl.Text = "INSERISCI DIFFICOLTA':";
            lbl.Size = new Size(250, 20);
            lbl.Location = new Point(10, 10);

            cmb.Name = "cmbDiff";
            cmb.Size = new Size(lbl.Width, 10);
            cmb.Location = new Point(10, 30);
            for (int i = 0; i < vDiff.Length; i++)
                cmb.Items.Add(vDiff[i]);
            cmb.SelectedIndex = 0; 
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.Cursor = Cursors.Hand;

            btn.Name = "btnGioca";
            btn.Text = "AVVIA PARTITA";
            btn.Size = new Size(lbl.Width, 50);
            btn.Location = new Point(10, 60);
            btn.Cursor = Cursors.Hand;
            btn.BackColor = Color.LightGreen;
            btn.Click += new EventHandler(btnGioca_Click);


            this.Controls.Add(lbl);
            this.Controls.Add(cmb);
            this.Controls.Add(btn);
        }

        private void btnGioca_Click(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox) this.Controls["cmbDiff"];
            int dim;
            //"FACILE: 10x10"
            // [0]: "FACILE: 10
            // [1]: "10"

            // DIM => Dimensione matrice e numero mine
            // 1. Recupero dimensione da difficoltà 
            dim = Convert.ToInt32(cmb.Text.Split('x')[1]);
            // 2. Istanza della matrice 
            m = new int[dim, dim];
            // 3. Reset 
            for(int i = this.Controls.Count - 1; i>=0; i--)
            {
                if (this.Controls[i] is Button && this.Controls[i].Name != "btnGioca")
                    this.Controls.RemoveAt(i);
            }
            // 4. Disegno campo da gioco 
            disegnaCampo(dim);
            // 5. Disabilito pulsante gioco 
            this.Controls["btnGioca"].Enabled = false;
            // 6. Posiziono Mine e Calcolo valori adiacenti
            posizionaMineECalcola(dim);
            // 7. Azzero contatore Vittoria 
            cntVittoria = (dim * dim) - dim; 
        }

        private void posizionaMineECalcola(int mine)
        {
            int i, j;
            int R = mine, C = mine;
            int cnt;
            // 1. Posiziono tutte le mine in modo casuale 
            for(int k=0; k<mine; k++)
            {
                do
                {
                    i = rnd.Next(0, R);
                    j = rnd.Next(0, C);
                } while (m[i, j] == -1); // -1 indica posizionamento mina
                m[i, j] = -1;
                //this.Controls["btn_" + i.ToString() + "_" 
                //                        + j.ToString()].BackColor = Color.Red;
            }

            // 2. Calcolo mine adiacenti
            for(i=0; i<R; i++)
            {
                for(j=0; j<C; j++)
                {
                    if (m[i,j] != -1)// Escludo celle contenent. mina
                    {
                        cnt = 0;
                        // Guardo intorno alla cella 
                        //sopra
                        if (i != 0)
                            cnt = cnt + (m[i - 1, j] == -1 ? 1 : 0); 
                        // sotto
                        if (i != R-1)
                            cnt = cnt + (m[i + 1, j] == -1 ? 1 : 0);
                        // dx 
                        if (j != C-1)
                            cnt = cnt + (m[i, j+1] == -1 ? 1 : 0);
                        // sx 
                        if (j != 0)
                            cnt = cnt + (m[i, j - 1] == -1 ? 1 : 0);
                        // alto sx 
                        if (i != 0 && j != 0)
                            cnt = cnt + (m[i - 1, j - 1] == -1 ? 1 : 0);
                        // basso sx 
                        if (i != R-1 && j != 0)
                            cnt = cnt + (m[i + 1, j - 1] == -1 ? 1 : 0);
                        // alto dx 
                        if (i != 0 && j != C-1)
                            cnt = cnt + (m[i - 1, j + 1] == -1 ? 1 : 0);
                        // basso dx 
                        if (i != R - 1 && j != C - 1)
                        {
                            cnt = cnt + (m[i + 1, j + 1] == -1 ? 1 : 0);
                            //if (m[i + 1, j + 1] == -1)
                            //    cnt ++;
                        }
                        m[i, j] = cnt; 
                        
                        //this.Controls["btn_" + i.ToString() + "_" + 
                        //            j.ToString()].Text = m[i,j].ToString(); 
                    } // fine for j 
                }// fine for i 
            }
        }

        private void disegnaCampo(int dim)
        {
            Button btn = new Button();
            int posX = 10, 
                posY = this.Controls["btnGioca"].Location.Y +
                       this.Controls["btnGioca"].Size.Height + 20; 
            for(int i=0; i<dim; i++)
            {
                for(int j=0; j<dim; j++)
                {
                    btn = new Button(); 
                    btn.Name = "btn_" + i.ToString() + "_" + j.ToString();
                    btn.Text = "";
                    btn.Size = new Size(25, 25);
                    btn.Location = new Point(posX, posY); 

                    btn.Cursor = Cursors.Hand;
                    btn.BackColor = Color.LightBlue;
                    btn.Click += new EventHandler(btnCampo_Click);
                    this.Controls.Add(btn);
                    posX = posX + 25;
                }
                posX = 10;
                posY = posY + 25;
            }
            this.Size = new Size(btn.Location.X + 100, btn.Location.Y + 100);
            //this.AutoSize = true; 
        }

        private void btnCampo_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int i, j;
            // btn_i_j 
            // [0] = "btn"
            // [1] = i
            // [2] = j
            i = Convert.ToInt32(btn.Name.Split('_')[1]); 
            j = Convert.ToInt32(btn.Name.Split('_')[2]);

            if (m[i, j] == -1) // COLPITO LA MINA: PERSO 
            {
                for (i = 0; i < m.GetLength(0); i++)
                    for (j = 0; j < m.GetLength(1); j++)
                        if (m[i, j] == -1)
                            this.Controls["btn_" + i.ToString() + "_" +
                                j.ToString()].BackColor = Color.Red;

                MessageBox.Show("PECCATO, HAI PERSO!");
                this.Controls["btnGioca"].Enabled = true;
            }
            else
            {
                btn.Text = m[i, j].ToString();
                switch(m[i, j])
                {
                    case 0:
                        btn.ForeColor = Color.Green;
                        break;
                    case 1:
                        btn.ForeColor = Color.Blue;
                        break;
                    case 2:
                        btn.ForeColor = Color.OrangeRed;
                        break;
                    default:
                        btn.ForeColor = Color.Red;
                        break;
                }

                cntVittoria--;
                // Rimuovo evento di click per il pulsante appena premuto 
                btn.Click -= new EventHandler(btnCampo_Click); 
                
                if(cntVittoria == 0)
                {
                    MessageBox.Show("BRAVO, HAI VINTO!");
                    this.Controls["btnGioca"].Enabled = true;
                }
            }
        }
    }
}
