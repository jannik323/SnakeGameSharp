using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Snake
    {
        int x;
        int y;
        SnakeGame snakeGame;
        public Direction direction=Direction.right;


        public Snake(SnakeGame snakeGame,int x =0, int y=0)
        {
            this.snakeGame = snakeGame;
            this.x = x;
            this.y = y;
        }

        public void Update()
        {
            switch (direction)
            {
                case Direction.up:
                    y--;
                    break;
                case Direction.left:
                    x--;
                    break;
                case Direction.down:
                    y++;
                    break;
                case Direction.right:
                    x++;
                    break;
            }

            if (x > snakeGame.getGridSize()-1)
            {
                x = 0;
            }

            if (y > snakeGame.getGridSize()-1)
            {
                y = 0;
            }

            if (x<0)
            {
                x = snakeGame.getGridSize()-1;
            }

            if (y < 0)
            {
                y = snakeGame.getGridSize()-1;
            }
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }
    }

    enum Direction{
        up,
        down,
        left,
        right
    }
}
