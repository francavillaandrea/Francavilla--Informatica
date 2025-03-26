using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prato_Fiorito
{
    public partial class FrmMain : Form
    {
        private const int GRID_SIZE = 10; // Dimensione della griglia 10x10
        private const int CELL_SIZE = 30; // Dimensione di ogni cella in pixel
        private const int MINE_COUNT = 10; // Numero di mine
        
        private Button[,] grid;
        private bool[,] mines;
        private bool[,] revealed;
        private bool gameOver;
        
        public FrmMain()
        {
            InitializeComponent();
            InitializeGame();
        }
        
        private void InitializeGame()
        {
            grid = new Button[GRID_SIZE, GRID_SIZE];
            mines = new bool[GRID_SIZE, GRID_SIZE];
            revealed = new bool[GRID_SIZE, GRID_SIZE];
            gameOver = false;
            
            // Creazione della griglia di pulsanti
            for (int i = 0; i < GRID_SIZE; i++)
            {
                for (int j = 0; j < GRID_SIZE; j++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(j * CELL_SIZE, i * CELL_SIZE);
                    btn.Size = new Size(CELL_SIZE, CELL_SIZE);
                    btn.Tag = new Point(i, j);
                    btn.MouseUp += Btn_MouseUp;
                    
                    grid[i, j] = btn;
                    this.Controls.Add(btn);
                }
            }
            
            // Posizionamento casuale delle mine
            Random rand = new Random();
            int minesPlaced = 0;
            while (minesPlaced < MINE_COUNT)
            {
                int i = rand.Next(GRID_SIZE);
                int j = rand.Next(GRID_SIZE);
                
                if (!mines[i, j])
                {
                    mines[i, j] = true;
                    minesPlaced++;
                }
            }
            
            // Impostazione dimensioni form
            this.ClientSize = new Size(GRID_SIZE * CELL_SIZE, GRID_SIZE * CELL_SIZE);
        }

        private void Btn_MouseUp(object sender, MouseEventArgs e)
        {
            if (gameOver) return;
            
            Button btn = (Button)sender;
            Point pos = (Point)btn.Tag;
            int row = pos.X;
            int col = pos.Y;
            
            if (e.Button == MouseButtons.Right)
            {
                if (!revealed[row, col])
                {
                    btn.Text = btn.Text == "🚩" ? "" : "🚩";
                }
                return;
            }
            
            if (e.Button == MouseButtons.Left && btn.Text != "🚩")
            {
                if (mines[row, col])
                {
                    RevealAllMines();
                    MessageBox.Show("Game Over!");
                    gameOver = true;
                }
                else
                {
                    RevealCell(row, col);
                    CheckWin();
                }
            }
        }

        private void RevealCell(int row, int col)
        {
            if (row < 0 || row >= GRID_SIZE || col < 0 || col >= GRID_SIZE || revealed[row, col])
                return;
                
            revealed[row, col] = true;
            int mineCount = CountAdjacentMines(row, col);
            
            if (mineCount == 0)
            {
                grid[row, col].Enabled = false;
                grid[row, col].Text = "";
                
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        RevealCell(row + i, col + j);
                    }
                }
            }
            else
            {
                grid[row, col].Text = mineCount.ToString();
                grid[row, col].Enabled = false;
            }
        }

        private int CountAdjacentMines(int row, int col)
        {
            int count = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int newRow = row + i;
                    int newCol = col + j;
                    if (newRow >= 0 && newRow < GRID_SIZE && newCol >= 0 && newCol < GRID_SIZE)
                    {
                        if (mines[newRow, newCol]) count++;
                    }
                }
            }
            return count;
        }

        private void RevealAllMines()
        {
            for (int i = 0; i < GRID_SIZE; i++)
            {
                for (int j = 0; j < GRID_SIZE; j++)
                {
                    if (mines[i, j])
                    {
                        grid[i, j].Text = "💣";
                        grid[i, j].BackColor = Color.Red;
                    }
                }
            }
        }

        private void CheckWin()
        {
            int unrevealedCount = 0;
            for (int i = 0; i < GRID_SIZE; i++)
            {
                for (int j = 0; j < GRID_SIZE; j++)
                {
                    if (!revealed[i, j] && !mines[i, j])
                        unrevealedCount++;
                }
            }
            
            if (unrevealedCount == 0)
            {
                MessageBox.Show("Hai vinto!");
                gameOver = true;
            }
        }
    }
}
