using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame{
    public partial class SnakeGame : Form{
        readonly Brush snakeBrush = new SolidBrush(Color.Green);
        readonly Brush snakeHeadBrush = new SolidBrush(Color.DarkGreen);
        readonly Brush appleBrush = new SolidBrush(Color.Red);
        int gridsize = 20;
        float gridscale;
        Snake snake;
        readonly public int applecount = 5;
        Apple[] apples;
        readonly public Random random = new Random();
        

        public SnakeGame(){
            InitializeComponent();
            RestartGame();

        }

        public void RestartGame(){
            gameloop.Enabled = true;
            gameloop.Interval = 100;
            gridscale = canvas.Width / gridsize;
            snake = new Snake(this,gridsize / 2, gridsize / 2);
            apples = new Apple[applecount];
            for(int i = 0; i < applecount; i++) {
                apples[i] = new Apple(this);
            }
        }
        private void canvas_Paint(object sender, PaintEventArgs ev){
            Graphics ctx = ev.Graphics;
            ctx.FillRectangle(snakeHeadBrush, snake.x* gridscale, snake.y * gridscale, gridscale, gridscale);
            snake.getBodies().ForEach(e => {
                ctx.FillRectangle(snakeBrush, e.x * gridscale, e.y * gridscale, gridscale, gridscale);
            });
            for(int i = 0; i < applecount; i++) {
                ctx.FillRectangle(appleBrush, apples[i].x * gridscale, apples[i].y * gridscale, gridscale, gridscale);
            }
        }

        private void gameloop_Tick(object sender, EventArgs e){

            snake.Update();
            canvas.Invalidate();
            points.Text = snake.getSize() + "";
        }

        private void keyDown(object sender, KeyEventArgs e){
            switch (e.KeyCode){
                case Keys.W:
                    if (snake.direction == Direction.down) break;
                    snake.direction = Direction.up;
                    break;
                case Keys.A:
                    if (snake.direction == Direction.right) break;
                    snake.direction = Direction.left;
                    break;
                case Keys.S:
                    if (snake.direction == Direction.up) break;
                    snake.direction = Direction.down;
                    break;
                case Keys.D:
                    if (snake.direction == Direction.left) break;
                    snake.direction = Direction.right;
                    break;
            }
        }

        public int getGridSize() => gridsize;

        public Apple[] getApples() => apples;
        public Snake getSnake() => snake;
    }
}
