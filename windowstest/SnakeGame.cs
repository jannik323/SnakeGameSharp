using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class SnakeGame : Form
    {
        Brush snakeBrush = new SolidBrush(Color.Green);
        Brush snakeHeadBrush = new SolidBrush(Color.DarkGreen);
        Brush appleBrush = new SolidBrush(Color.Red);
        int gridsize = 20;
        float gridscale;
        Snake snake;
        

        public SnakeGame()
        {
            InitializeComponent();
            RestartGame();

        }

        private void RestartGame()
        {
            gameloop.Enabled = true;
            gridscale = canvas.Width / gridsize;
            snake = new Snake(this,gridsize / 2, gridsize / 2);


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics ctx = e.Graphics;
            ctx.FillRectangle(snakeHeadBrush, snake.getX()* gridscale, snake.getY() * gridscale, gridscale, gridscale);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            snake.Update();
            canvas.Invalidate();
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    snake.direction = Direction.up;
                    break;
                case Keys.A:
                    snake.direction = Direction.left;
                    break;
                case Keys.S:
                    snake.direction = Direction.down;
                    break;
                case Keys.D:
                    snake.direction = Direction.right;
                    break;
            }
        }

        public int getGridSize()
        {
            return gridsize;
        }
    }
}
