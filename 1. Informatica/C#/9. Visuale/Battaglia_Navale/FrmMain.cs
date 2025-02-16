using System;
using System.Drawing;
using System.Windows.Forms;

namespace BattagliaNavale
{
    public partial class FrmMain : Form
    {
        private const int rows = 5;
        private const int cols = rows;
        private const int maxTentativi = 7;
        private const int nNavi = 3;
        private bool[,] navi = new bool[rows, cols];
        private bool giocoIniziato = false;
        private int tentRimanenti;

        public FrmMain()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            dgv1.ClearSelection();
            dgv1.RowHeadersVisible = false;
            dgv1.ColumnHeadersVisible = false;
            dgv1.ColumnCount = cols;
            dgv1.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dgv1.Rows[i].Cells[j].Value = "";
                    dgv1.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                }
            }
        }
        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!giocoIniziato)
            {
                MessageBox.Show("Inizia prima il gioco!");
                return;
            }

            int row = e.RowIndex;
            int col = e.ColumnIndex;

            if (row >= 0 && col >= 0)
            {
                if (dgv1.Rows[row].Cells[col].Value != null)
                {
                    MessageBox.Show("Hai già attaccato questa cella!");
                    return;
                }

                tentRimanenti--;

                if (navi[row, col])
                {
                    dgv1.Rows[row].Cells[col].Style.BackColor = Color.Red;
                }
                else
                {
                    dgv1.Rows[row].Cells[col].Style.BackColor = Color.White;
                }

                lblMessage.Text = tentRimanenti > 0
                    ? $"Tentativi rimasti: {tentRimanenti}."
                    : "Hai esaurito i tentativi!";

                if (CheckVictory())
                {
                    MessageBox.Show("Hai vinto! Hai affondato tutte le navi!");
                    EndGame();
                }
                else if (tentRimanenti <= 0)
                {
                    MessageBox.Show("Hai perso! Hai esaurito i tentativi.");
                    EndGame();
                }
            }
        }

        private bool CheckVictory()
        {
            foreach (var ship in navi)
            {
                if (ship) return false;
            }
            return true;
        }

        private void EndGame()
        {
            giocoIniziato = false;
            InitializeGrid();
            lblMessage.Text = "Il gioco è finito. Premi 'Inizia Gioco' per ricominciare.";
        }

        private void btnStartGame_Click_1(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < nNavi; i++)
            {
                int x = rand.Next(rows);
                int y = rand.Next(cols);
                navi[x, y] = true;
            }
            giocoIniziato = true;
            tentRimanenti = maxTentativi;
            lblMessage.Text = $"Gioco iniziato! Tentativi rimasti: {tentRimanenti}. Ci sono {nNavi} navi da affondare. Effettua un attacco.";

        }
    }
}