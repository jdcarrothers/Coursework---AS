using Coursework_0._0.Forms.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_0._0.Forms.Minigames
{
    public partial class SnakeForm : GamesTemplate
    {
        private List<SnakeSquare> snake = new List<SnakeSquare>();
        private SnakeSquare point = new SnakeSquare();
        private SnakeSquare PointToAdd;
        private int score = 0;
        private bool gameOver = false;
        private SnakeDirection direction;
        public SnakeForm()
        {
            snake.Add(new SnakeSquare(12, 14));
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Start the game
            lblGameOver.Visible = false;
            gameOver = false;
            snake = new List<SnakeSquare>();
            point = new SnakeSquare();
            snake.Add(new SnakeSquare(12, 14));
            lblGameOver.Visible = false;
            score = 0;
            lblScore.Text = "Score: " + score.ToString();
            timer.Interval = 80;
            timer.Start();
        }

        private void imgSnakeArea_Paint(object sender, PaintEventArgs e)
        {
            // Draw the snake and the point
            Graphics graphics = e.Graphics;
            for (int x = 0; x < snake.Count; x++)
            {
                graphics.FillRectangle(Brushes.White, new Rectangle(snake[x].X * 20, snake[x].Y * 20, 20, 20));
            }
            graphics.FillRectangle(Brushes.DimGray, new Rectangle(point.X * 20, point.Y * 20, 20, 20));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Move the snake
            bool pointGained = false;
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    if (snake[i].X == point.X && snake[i].Y == point.Y)
                    {
                        PointToAdd = new SnakeSquare(snake[snake.Count - 1].X, snake[snake.Count - 1].Y);
                        score += 1;
                        lblScore.Text = "Score: " + score.ToString();
                        point = new SnakeSquare();
                        pointGained = true;
                    }

                    if (direction == SnakeDirection.Up) 
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
                        if (snake[i].X == snake[j].X && snake[i].Y == snake[j].Y) 
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
                lblGameOver.Text = "Game Over.\n Use W/A/S/D to navigate the snake.";
                lblGameOver.Visible = true;
                timer.Stop();
            }
        }

        private void SnakeForm_KeyPress(object sender, KeyPressEventArgs keyPressed)
        {
            // Change the direction of the snake
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form instructionBox = new InstructionBox("Use W-up, A-left, D-right, S-down to traverse the game area collecting pellets to grow your snake without hitting the sides or yourself.", Coursework_0._0.Properties.Resources.WASD_Key);
            instructionBox.ShowDialog();
        }
    }
}
