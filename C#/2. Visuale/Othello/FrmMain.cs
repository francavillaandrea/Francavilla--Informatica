using System;
using System.Drawing;
using System.Windows.Forms;

namespace Othello
{
    public partial class FrmMain : Form
    {
        static Random rnd = new Random();
        bool player;
        const int grid = 8;
        int turno = rnd.Next(0, 2);
        Label lblTurno, lblNeri, lblBianchi, lblTitolo;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Othello";
            creaCampo();
        }

        private void creaCampo()
        {
            lblTitolo = new Label
            {
                Text = "OTHELLO",
                Font = new Font("Arial", 24, FontStyle.Bold),
                Location = new Point(200, 10),
                AutoSize = true
            };
            this.Controls.Add(lblTitolo);

            int posX = 5, posY = 50;
            for (int i = 0; i < grid; i++)
            {
                for (int j = 0; j < grid; j++)
                {
                    Button btn = new Button
                    {
                        Name = $"btn_{i}_{j}",
                        Text = "",
                        Location = new Point(posX, posY),
                        Size = new Size(50, 50),
                        BackColor = Color.Gray,
                        ForeColor = Color.White,
                        Font = new Font("Arial", 10, FontStyle.Bold)
                    };
                    posX += 55;
                    this.Controls.Add(btn);

                    if ((i == 3 && j == 3) || (i == 4 && j == 4))
                    {
                        btn.BackColor = Color.Black;
                    }
                    else if ((i == 3 && j == 4) || (i == 4 && j == 3))
                    {
                        btn.BackColor = Color.White;
                    }
                    btn.Click += new EventHandler(btnCampo_click);
                }
                posX = 5;
                posY += 55;
            }

            lblTurno = new Label
            {
                Location = new Point(450, 80),
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            lblNeri = new Label
            {
                Location = new Point(450, 120),
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            lblBianchi = new Label
            {
                Location = new Point(450, 150),
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            this.Controls.Add(lblTurno);
            this.Controls.Add(lblNeri);
            this.Controls.Add(lblBianchi);
            AggiornaTurno();
        }

        private void btnCampo_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || btn.BackColor != Color.Gray)
            {
                return;
            }

            if (IsMossaValida(btn))
            {
                EseguiMossa(btn);
                AggiornaTurno();
                if (!CiSonoMosseDisponibili())
                {
                    FinePartita();
                }
            }
            else
            {
                MessageBox.Show("Mossa non valida.");
            }
        }

        private bool IsMossaValida(Button btn)
        {
            int x = (btn.Location.X - 5) / 55;
            int y = (btn.Location.Y - 50) / 55;

            return IsMossaValida(x, y, player);
        }

        private bool IsMossaValida(int x, int y, bool giocatore)
        {
            bool mossaValida = false;

            Color colore = giocatore ? Color.White : Color.Black;
            Color avversario = giocatore ? Color.Black : Color.White;

            // Controlla tutte le direzioni per vedere se la mossa è valida
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    if (dx == 0 && dy == 0) continue;  // Non controllare la stessa cella

                    mossaValida |= ControllaDirezione(x, y, dx, dy, colore, avversario);
                }
            }
            return mossaValida;
        }

        private bool ControllaDirezione(int x, int y, int dx, int dy, Color colore, Color avversario)
        {
            int i = x + dx;
            int j = y + dy;

            bool trovatoAvversario = false;
            while (i >= 0 && i < grid && j >= 0 && j < grid)
            {
                Button btn = (Button)this.Controls[$"btn_{i}_{j}"];
                if (btn.BackColor == avversario)
                {
                    trovatoAvversario = true;
                }
                else if (btn.BackColor == colore)
                {
                    return trovatoAvversario;
                }
                else
                {
                    break;
                }

                i += dx;
                j += dy;
            }
            return false;
        }

        private void EseguiMossa(Button btn)
        {
            int x = (btn.Location.X - 5) / 55;
            int y = (btn.Location.Y - 50) / 55;

            Color colore = player ? Color.White : Color.Black;
            btn.BackColor = colore;

            // Capovolgi le pedine
            CapovolgiPedine(x, y, colore);

            // Cambia il turno
            player = !player;
        }

        private void CapovolgiPedine(int x, int y, Color colore)
        {
            Color avversario = colore == Color.White ? Color.Black : Color.White;

            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    if (dx == 0 && dy == 0) continue;

                    CapovolgiInDirezione(x, y, dx, dy, colore, avversario);
                }
            }
        }

        private void CapovolgiInDirezione(int x, int y, int dx, int dy, Color colore, Color avversario)
        {
            int i = x + dx;
            int j = y + dy;

            // Controlla se ci sono pedine avversarie
            while (i >= 0 && i < grid && j >= 0 && j < grid)
            {
                Button btn = (Button)this.Controls[$"btn_{i}_{j}"];
                if (btn.BackColor == avversario)
                {
                    i += dx;
                    j += dy;
                }
                else if (btn.BackColor == colore)
                {
                    // Capovolgi le pedine avversarie
                    while (i != x || j != y)
                    {
                        Button btnDaCapovolgere = (Button)this.Controls[$"btn_{i}_{j}"];
                        btnDaCapovolgere.BackColor = colore;
                        i -= dx;
                        j -= dy;
                    }
                    break;
                }
                else
                {
                    break;
                }
            }
        }

        private void AggiornaTurno()
        {
            lblTurno.Text = player ? "Turno: Bianco" : "Turno: Nero";
            AggiornaConteggio();
        }

        private void AggiornaConteggio()
        {
            int cntNere = 0, cntBianche = 0;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    if (btn.BackColor == Color.Black)
                    {
                        cntNere++;
                    }
                    else if (btn.BackColor == Color.White)
                    {
                        cntBianche++;
                    }
                }
            }
            lblNeri.Text = $"Nere: {cntNere}";
            lblBianchi.Text = $"Bianche: {cntBianche}";
        }

        private bool CiSonoMosseDisponibili()
        {
            for (int i = 0; i < grid; i++)
            {
                for (int j = 0; j < grid; j++)
                {
                    Button btn = (Button)this.Controls[$"btn_{i}_{j}"];
                    if (btn.BackColor == Color.Gray && IsMossaValida(i, j, player))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void FinePartita()
        {
            int cntNere = 0, cntBianche = 0;
            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    if (btn.BackColor == Color.Black)
                    {
                        cntNere++;
                    }
                    else if (btn.BackColor == Color.White)
                    {
                        cntBianche++;
                    }

                }
            }
            string risultato = cntNere > cntBianche ? "Nero vince!" : (cntBianche > cntNere ? "Bianco Vince" : "Pareggio!");
            MessageBox.Show(risultato);
        }



    }
}
