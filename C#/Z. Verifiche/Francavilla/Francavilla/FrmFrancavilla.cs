using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Francavilla
{
    public partial class FrmFrancavilla : Form
    {
        static Random rnd = new Random();
        int tentV = 3;
        int tentS = 3;
        int rows = 4, cols = 4;
        int nEstratto = rnd.Next(1,10);
        Button btn;
        Label lblR;
        TextBox txtR;
        Label lblC;
        TextBox txtC;
        Button btnS;
        Button btnE;
        Label lblEstratto;
        public FrmFrancavilla()
        {
            InitializeComponent();
        }

        private void FrmFrancavilla_Load(object sender, EventArgs e)
        {
            this.Text = "Francavilla";
            generaCampo();
        }

        private void generaCampo()
        {
            int n;
            lblR = new Label
            {
                Text = "#Righe:",
                Location = new Point(5, 5),
                AutoSize = true,
                Font = new Font(Font, FontStyle.Bold)
        };
            this.Controls.Add(lblR);
            txtR = new TextBox
            {
                Name = "txtR",
                Location = new Point(15, 5),

            };
            this.Controls.Add(txtR);
            lblC = new Label
            {
                Text = "#Colonne:",
                Location = new Point(30, 5),
                AutoSize = true,
                Font = new Font(Font, FontStyle.Bold)
            };
            this.Controls.Add(lblC);
            txtC = new TextBox
            {
                Name = "txtC",
                Location = new Point(45, 5),

            };
            this.Controls.Add(txtC);

            int posX = 5, posY = 30;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    n = rnd.Next(1, 10);
                    btn = new Button
                    {
                        Text = $"{n}",
                        Name = $"btn_{i}",
                        Location = new Point(posX, posY),
                        Size = new Size(50, 50),
                        Font = new Font("Arial", 10, FontStyle.Bold)
                    };
                    posX += 55;
                    btn.Click += new EventHandler(btnCampo_Click);
                    this.Controls.Add(btn);
                }
                posX = 5;
                posY += 55;
            }
            btnS = new Button
            {
                Name = "btnStartGame",
                Text = "AVVIA PARTITA",
                BackColor = Color.Green,
                ForeColor = Color.White,
                Location = new Point(700, 15)

            };
            btnS.Click += new EventHandler(btnAvviaPartita_Click);
            this.Controls.Add(btnS);

            btnE = new Button
            {
                Name = "btnEstrai",
                Text = "Estrai",
                BackColor = Color.Red,
                ForeColor = Color.White,
                Location = new Point(posX + 50, posY + 50)
            };
            this.Controls.Add(btnE);
            btnE.Click += new EventHandler(btnEstraiNumero_Click);
            lblEstratto = new Label
            {
                Name = "lblEstratto",
                Text = $"Numero estratto: {nEstratto}",
                AutoSize = true,
                Location = new Point(posX+200, posY+50)
            };
            this.Controls.Add(lblEstratto);
        }
        

        private void btnCampo_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(this.Controls[$"btn_{i}"].Text) == nEstratto)
            {
                this.Controls["btn"].BackColor = Color.Green;
                tentV--;
                btnEstraiNumero_Click(sender,e);

                if (tentV == 0)
                {
                    MessageBox.Show("Hai vinto!");
                    resetGame();
                    
                }
            }
            else
            {
                this.Controls["btn"].BackColor = Color.Red;
                tentS--;
                btnEstraiNumero_Click(sender,e);

                if (tentS == 0)
                {
                    MessageBox.Show("Hai perso!");
                    resetGame();
                }
            }
        }

        private void resetGame()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    this.Controls[$"btn_{i}"].Enabled = false;
                }
            }
            this.Controls[$"btnStartGame"].Enabled = true;
            this.Controls[$"btnGenera"].Enabled = true;
            
        }

        private void btnEstraiNumero_Click(object sender, EventArgs e)
        {
            nEstratto = rnd.Next(1, 10);
            this.Controls["lblEstratto"].Text = $"Numero estratto: {nEstratto}";

        }

        private void btnAvviaPartita_Click(object sender, EventArgs e)
        {
            generaCampo();
            btnS.Enabled = false;
        }


    }
}

