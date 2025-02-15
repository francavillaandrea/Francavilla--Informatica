using System;

namespace Prato_Fiorit
{
    public class ClsMinesweeper
    {
        private const int GridSize = 8;
        private const int BombCount = 10;
        private int[,] gameBoard;
        private bool[,] revealedCells;
        private bool[,] flaggedCells;
        private bool gameOver;

        public ClsMinesweeper()
        {
            InitializeGame();
        }

        public void InitializeGame()
        {
            gameBoard = new int[GridSize, GridSize];
            revealedCells = new bool[GridSize, GridSize];
            flaggedCells = new bool[GridSize, GridSize];
            gameOver = false;
            InitializeGameBoard();
        }

        private void InitializeGameBoard()
        {
            Random random = new Random();
            int bombsPlaced = 0;

            while (bombsPlaced < BombCount)
            {
                int row = random.Next(GridSize);
                int col = random.Next(GridSize);

                if (gameBoard[row, col] != -1)
                {
                    gameBoard[row, col] = -1; // Place bomb
                    bombsPlaced++;

                    // Update adjacent cells
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            int newRow = row + i;
                            int newCol = col + j;

                            if (newRow >= 0 && newRow < GridSize && newCol >= 0 && newCol < GridSize && gameBoard[newRow, newCol] != -1)
                            {
                                gameBoard[newRow, newCol]++;
                            }
                        }
                    }
                }
            }
        }

        public bool RevealCell(int row, int col)
        {
            if (gameOver || revealedCells[row, col] || flaggedCells[row, col])
                return false;

            revealedCells[row, col] = true;

            if (gameBoard[row, col] == -1)
            {
                gameOver = true;
                return true; // Bomb revealed
            }

            if (gameBoard[row, col] == 0)
            {
                // Reveal adjacent cells
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        int newRow = row + i;
                        int newCol = col + j;

                        if (newRow >= 0 && newRow < GridSize && newCol >= 0 && newCol < GridSize)
                        {
                            RevealCell(newRow, newCol);
                        }
                    }
                }
            }

            return false;
        }

        public void FlagCell(int row, int col)
        {
            if (gameOver || revealedCells[row, col])
                return;

            flaggedCells[row, col] = !flaggedCells[row, col];
        }

        public bool CheckWinCondition()
        {
            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    if (gameBoard[i, j] != -1 && !revealedCells[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool IsGameOver()
        {
            return gameOver;
        }

        public string GetCellState(int row, int col)
        {
            if (flaggedCells[row, col])
                return "Flagged";

            if (!revealedCells[row, col])
                return "Hidden";

            if (gameBoard[row, col] == -1)
                return "Bomb";

            return gameBoard[row, col] == 0 ? "Empty" : gameBoard[row, col].ToString();
        }
    }
}
