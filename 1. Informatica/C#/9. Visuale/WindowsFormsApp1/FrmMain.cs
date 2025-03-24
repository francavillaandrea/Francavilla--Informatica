using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class FrmMain : Form
    {
        static Random rnd = new Random();
        int[,] m;
        int contVittoria;//Contatore pulsnati di gioco cliccati


        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Campo Minato";
            disegnaDifficolta();
        }

        private void disegnaDifficolta()
        {
            Label lbl = new Label();
            ComboBox cmb = new ComboBox();
            Button btn = new Button();
            string[] vDifficolta = { "Facile: 10x10", "Media: 20x20", "Difficile: 30x30" };


            lbl.Text = "Inserisci la difficoltà";
            lbl.Size = new Size(250, 20);
            lbl.Location = new Point(10, 10);

            cmb.Name = "cmbDifficolta";
            cmb.Size = new Size(lbl.Width, 10);
            cmb.SelectedIndex = -1;
            cmb.Location = new Point(10, 30);
            for (int i = 0; i < vDifficolta.Length; i++)
            {
                cmb.Items.Add(vDifficolta[i]);
            }
            cmb.SelectedIndex = -1;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.Cursor = Cursors.Hand;

            btn.Name = "btnGioca";
            btn.Text = "Avvia Partita";
            btn.Size = new Size(lbl.Width, 50);
            btn.Location = new Point(10, 60);
            btn.BackColor = Color.LightGreen;
            btn.Cursor = Cursors.Hand;
            btn.Click += new EventHandler(btnGioca_click);

            this.Controls.Add(btn);
            this.Controls.Add(lbl);
            this.Controls.Add(cmb);

        }

        private void btnGioca_click(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)this.Controls["cmbDifficolta"];

            if (cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Inserisci una difficoltà prima di giocare!");
            }
            else
            {
                //1. Recupero dimensioni campo
                int size = Convert.ToInt32(cmb.Text.Split('x')[1]);
                //2. Instanza della matrice
                m = new int[size, size];
                //3. Reset
                for (int i = this.Controls.Count -1; i >= 0; i--)
                {
                    if (this.Controls[i] is Button && this.Controls[i].Name != "btnGioca")
                    {
                        this.Controls.RemoveAt(i);
                    }
                }
                //4. Disegna Campo da gioco
                disegnaCampo(size);
                //5.Disabilito il pulsante gioca 
                this.Controls["btnGioca"].Enabled = false;
                //6. Posiziona mine e valori adiacenti
                posizionaMineECalcola(size);
                //7. Azzero contatore vittoria
                contVittoria = (size * size) - size;
            }


        }

        private void posizionaMineECalcola(int nMine)
        {
            int i, j;
            int rows = nMine, cols = nMine;
            int cnt;
            // 1. Posiziono tutte le mine in modo casuale 
            for (int k = 0; k < nMine; k++)
            {
                do
                {
                    i = rnd.Next(0, rows);
                    j = rnd.Next(0, cols);
                } while (m[i, j] == -1); // -1 indica posizionamento mina
                m[i, j] = -1;
            }

            // 2. Calcolo mine adiacenti
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    if (m[i, j] != -1)// Escludo celle contenent. mina
                    {
                        cnt = 0;
                        // Guardo intorno alla cella 
                        //sopra
                        if (i != 0)
                            cnt += (m[i - 1, j] == -1 ? 1 : 0);
                        // sotto
                        if (i != rows - 1)
                            cnt += (m[i + 1, j] == -1 ? 1 : 0);
                        // dx 
                        if (j != cols - 1)
                            cnt += (m[i, j + 1] == -1 ? 1 : 0);
                        // sx 
                        if (j != 0)
                            cnt += (m[i, j - 1] == -1 ? 1 : 0);
                        // alto sx 
                        if (i != 0 && j != 0)
                            cnt += (m[i - 1, j - 1] == -1 ? 1 : 0);
                        // basso sx 
                        if (i != rows - 1 && j != 0)
                            cnt += (m[i + 1, j - 1] == -1 ? 1 : 0);
                        // alto dx 
                        if (i != 0 && j != cols - 1)
                            cnt += (m[i - 1, j + 1] == -1 ? 1 : 0);
                        // basso dx 
                        if (i != rows - 1 && j != cols - 1)
                            cnt += (m[i + 1, j + 1] == -1 ? 1 : 0);

                        m[i, j] = cnt;
                    } // fine for j
                }// fine for i 
            }
        }

        private void disegnaCampo(int size)
        {
            Button btn;
            int posX = 10, posY = this.Controls["btnGioca"].Location.Y + this.Controls["btnGioca"].Size.Height + 20;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    btn = new Button();
                    btn.Name = $"btn_{i}_{j}";
                    btn.Text = "";
                    btn.Size = new Size(25, 25);
                    btn.Location = new Point(posX, posY);
                    btn.BackColor = Color.LightBlue;
                    btn.Cursor = Cursors.Hand;
                    btn.Click += new EventHandler(btnCampo_click);
                    this.Controls.Add(btn);
                    posX += 25;

                }
                posX = 10;
                posY += 25;
            }
            this.AutoSize = true;
        }

        private void btnCampo_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int i, j;

            i = Convert.ToInt32(btn.Name.Split('_')[1]);
            j = Convert.ToInt32(btn.Name.Split('_')[2]);

            if (m[i,j] == -1)
            {
                for (i = 0; i < m.GetLength(0); i++)
                {
                    for (j = 0; j < m.GetLength(1); j++)
                    {
                        if (m[i,j] == -1)
                        {
                            this.Controls[$"btn_{i}_{j}"].BackColor = Color.Red;
                        }
                    }
                }
                MessageBox.Show("hai perso, sega");
                this.Controls["btnGioca"].Enabled = true;
            }
            else
            {
                btn.Text = m[i,j].ToString();
                switch (m[i, j])
                {
                    case 0:
                        {
                            btn.ForeColor = Color.Green;
                            break;
                        }
                    case 1:
                        {
                            btn.ForeColor = Color.Blue;
                            break;
                        }
                    case 2:
                        {
                            btn.ForeColor = Color.OrangeRed;
                            break;
                        }
                    default:
                        {
                            btn.ForeColor = Color.Red;
                            break;
                        }
                }
                contVittoria--;
                btn.Click -= new EventHandler(btnCampo_click);
                if(contVittoria == 0)
                {
                    MessageBox.Show("Brau, hai vinto");
                    this.Controls["btnGioca"].Enabled = true;
                }
            }

        }
    }
}
