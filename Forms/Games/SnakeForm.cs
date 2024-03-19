using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _22_11_21_Final_Coursework
{
    public partial class SnakeForm : Form
    {
        private List<SnakeSquare> snake = new List<SnakeSquare>();
        private SnakeSquare point = new SnakeSquare();
        private SnakeSquare PointToAdd;
        private int score = 0;
        private bool gameOver = false;
        private SnakeDirection direction;

        public SnakeForm()
        {
            snake.Add(new SnakeSquare(12,14));
            InitializeComponent();
            lblGameOver.Visible = false;
        }

        private void ImgSnakeArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            for (int x = 0; x < snake.Count; x++)
            {
                graphics.FillRectangle(Brushes.White, new Rectangle(snake[x].X * 20, snake[x].Y * 20, 20, 20));
            }
            graphics.FillRectangle(Brushes.DimGray, new Rectangle(point.X * 20, point.Y * 20, 20, 20));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            bool pointGained = false;
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0) //If this is the head of the snake.
                {
                    if (snake[i].X == point.X && snake[i].Y == point.Y) //If the snake has collected an apple.
                    {
                        PointToAdd = new SnakeSquare(snake[snake.Count - 1].X, snake[snake.Count - 1].Y); //Add a square to be added to the snake.
                        score += 1;
                        lblScore.Text = "Score: " + score.ToString();
                        point = new SnakeSquare();
                        pointGained = true;
                    }

                    if (direction == SnakeDirection.Up) //Decides the direction in which the snake goes.
                    {
                        snake[0].Y = snake[0].Y - 1;
                    }
                    else if (direction == SnakeDirection.Left)
                    {
                        snake[0].X = snake[0].X - 1;
                    }
                    else if (direction == SnakeDirection.Right)
                    {
                        snake[0].X = snake[0].X + 1;
                    }
                    else if (direction == SnakeDirection.Down)
                    {
                        snake[0].Y = snake[0].Y + 1;
                    }

                    if (snake[0].X > 40 || snake[0].Y > 24 || snake[0].X < 0 || snake[0].Y < 0) //Checks if the head of the snake has hit the sides of the picture box.
                    { gameOver = true; }

                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].X == snake[j].X && snake[i].Y == snake[j].Y) //Checks if the snake has hit itself.
                        {
                            gameOver = true;
                        }
                    }
                }
                else
                {
                    snake[i].X = snake[i - 1].X; //Move the squares of the snake to the positions of the squares before it.
                    snake[i].Y = snake[i - 1].Y;
                }
            }
            if (pointGained == true)
            {
                snake.Add(PointToAdd); //Add the square from before to the snake - this has to be done outside the for loop.
                pointGained = false;
            }

            imgSnakeArea.Invalidate(); //Make the picture box visually show the new snake and possibly apple.

            if (gameOver == true)
            {
                lblGameOver.Text = "Game Over";
                lblGameOver.Visible = true;
                timer.Stop();
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            gameOver = false;
            snake = new List<SnakeSquare>();
            point = new SnakeSquare();
            snake.Add(new SnakeSquare(12,14));
            lblGameOver.Visible = false;
            score = 0;
            lblScore.Text = "Score: " + score.ToString();
            timer.Interval = 80;
            timer.Start();
        }

        private void SnakeForm_KeyPress(object sender, KeyPressEventArgs keyPressed)
        {
            if (keyPressed.KeyChar == 38 || keyPressed.KeyChar == 87 || keyPressed.KeyChar == 119) 
            {
                if (direction != SnakeDirection.Down)
                { direction = SnakeDirection.Up; }
            }
            else if (keyPressed.KeyChar == 40 || keyPressed.KeyChar == 83 || keyPressed.KeyChar == 115)
            {
                if (direction != SnakeDirection.Up)
                { direction = SnakeDirection.Down; }
            }
            else if (keyPressed.KeyChar == 39 || keyPressed.KeyChar == 68 || keyPressed.KeyChar == 100)
            {
                if (direction != SnakeDirection.Left)
                { direction = SnakeDirection.Right; }
            }
            else if (keyPressed.KeyChar == 37 || keyPressed.KeyChar == 65 || keyPressed.KeyChar == 97)
            {
                if (direction != SnakeDirection.Right)
                { direction = SnakeDirection.Left; }
            }
        }

        private void PnlHeader_Paint(object sender, PaintEventArgs e)
        {
            pnlHeader.DrawBottomBorder(e);
        }

        private void BtnInstructions_Click(object sender, EventArgs e)
        {
            Form instructionBox = new InstructionBox("Use W-up, A-left, D-right, S-down to traverse the game area collecting pellets to grow your snake without hitting the sides or yourself.", Image.FromFile("../../../Assets/Images/WASD-Key.png"));
            instructionBox.ShowDialog();
        }
    }
}
