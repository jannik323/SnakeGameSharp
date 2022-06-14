using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame {
    public class Apple {
        public int x;
        public int y;
        readonly SnakeGame snakeGame;
        public Apple(SnakeGame snakeGame) {
            this.snakeGame = snakeGame;
            randomPos();
        }

        public void randomPos() {
            do {
                x = snakeGame.random.Next(snakeGame.getGridSize());
                y = snakeGame.random.Next(snakeGame.getGridSize());
            } while (snakeGame.getSnake().getBodies().Exists(e=>e.x==x&&e.y==y));
        }


     
    }
}
