using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private List<Rectangle> snake;
        private Rectangle food;
        private int snakeDirection;
        private Timer gameTimer;
        private int score;
        private int snakeSpeed;

        private const int CellSize = 20;
        private const int GridWidth = 20;
        private const int GridHeight = 20;
        private Random rand;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Snake Game";
            this.Width = 400;
            this.Height = 400;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            this.snake = new List<Rectangle>();
            this.rand = new Random();

            InitializeGame();

            // Timer per il gioco
            gameTimer = new Timer();
            gameTimer.Interval = 100; // 100 ms, puoi cambiare per velocizzare o rallentare il gioco
            gameTimer.Tick += GameTick;
            gameTimer.Start();

            this.KeyDown += Form1_KeyDown;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void InitializeGame()
        {
            snake.Clear();
            snake.Add(new Rectangle(100, 100, CellSize, CellSize)); // La testa del serpente
            snakeDirection = 1; // Movimento iniziale a destra
            score = 0;
            snakeSpeed = 100; // Velocità iniziale

            GenerateFood();
        }

        private void GenerateFood()
        {
            food = new Rectangle(rand.Next(0, GridWidth) * CellSize, rand.Next(0, GridHeight) * CellSize, CellSize, CellSize);
        }

        private void GameTick(object sender, EventArgs e)
        {
            // Movimento del serpente
            Rectangle head = snake[0];
            Rectangle newHead;

            switch (snakeDirection)
            {
                case 0: // Su
                    newHead = new Rectangle(head.X, head.Y - CellSize, CellSize, CellSize);
                    break;
                case 1: // Destra
                    newHead = new Rectangle(head.X + CellSize, head.Y, CellSize, CellSize);
                    break;
                case 2: // Giù
                    newHead = new Rectangle(head.X, head.Y + CellSize, CellSize, CellSize);
                    break;
                case 3: // Sinistra
                    newHead = new Rectangle(head.X - CellSize, head.Y, CellSize, CellSize);
                    break;
                default:
                    newHead = head;
                    break;
            }

            // Controlla se il serpente mangia il cibo
            if (newHead.IntersectsWith(food))
            {
                score++;
                GenerateFood(); // Genera nuovo cibo
                snake.Insert(0, newHead); // Aggiungi un segmento alla testa del serpente
            }
            else
            {
                snake.Insert(0, newHead); // Muovi la testa del serpente
                snake.RemoveAt(snake.Count - 1); // Rimuovi l'ultima parte del serpente
            }

            // Controlla se il serpente si è scontrato con se stesso o con i bordi
            if (newHead.X < 0 || newHead.Y < 0 || newHead.X >= GridWidth * CellSize || newHead.Y >= GridHeight * CellSize || snake.Contains(newHead))
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over! Score: " + score);
                InitializeGame();
                gameTimer.Start();
            }

            this.Invalidate(); // Rende necessario ridisegnare il form
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && snakeDirection != 2) snakeDirection = 0; // Su
            if (e.KeyCode == Keys.Right && snakeDirection != 3) snakeDirection = 1; // Destra
            if (e.KeyCode == Keys.Down && snakeDirection != 0) snakeDirection = 2; // Giù
            if (e.KeyCode == Keys.Left && snakeDirection != 1) snakeDirection = 3; // Sinistra
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Disegna il serpente
            foreach (var segment in snake)
            {
                e.Graphics.FillRectangle(Brushes.Green, segment);
            }

            // Disegna il cibo
            e.Graphics.FillRectangle(Brushes.Red, food);

            // Disegna il punteggio
            e.Graphics.DrawString("Score: " + score, new Font("Arial", 12), Brushes.Black, 10, 10);
        }
    }
}
