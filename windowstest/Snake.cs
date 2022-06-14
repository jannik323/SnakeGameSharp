using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame{
    public class Snake : Body{
        readonly SnakeGame snakeGame;
        public Direction direction=Direction.right;
        readonly List<Body> bodies = new List<Body>();
        int size = 3;
        public Snake(SnakeGame snakeGame,int x =0, int y=0):base(){
            this.snakeGame = snakeGame;
            this.x = x;
            this.y = y;
        }

        public void Update(){


            //add new body;
            if (size > bodies.Count) {
                Body newbody;
                if (bodies.Count > 0) {
                    newbody = new Body(bodies[bodies.Count - 1]);
                    bodies[bodies.Count - 1].setToParentPos();
                //incase that its the first body;
                } else {
                    newbody = new Body(this);
                }
                bodies.Add(newbody);
            //update positions of bodies;
            }else if (bodies.Count > 0) {
                bodies[bodies.Count - 1].setToParentPos();
            }


            //movement
            switch (direction){
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


            //border check
            if (x > snakeGame.getGridSize()-1){
                x = 0;
                size++;
            }

            if (y > snakeGame.getGridSize()-1){
                y = 0;
            }

            if (x<0){
                x = snakeGame.getGridSize()-1;
            }

            if (y < 0){
                y = snakeGame.getGridSize()-1;
            }

            //eat apples
            Apple[] apples = snakeGame.getApples();
            for(int i = 0; i < snakeGame.applecount; i++) {
                if (apples[i].x == this.x && apples[i].y == this.y) {
                    apples[i].randomPos();
                    size++;
                }
            }

            // body collision
            bodies.ForEach(e => {
                if (e.x == this.x && e.y == this.y) {
                    snakeGame.RestartGame();
                }
            });
        }

        //getters
        public int getSize() {
            return bodies.Count;
        }
        public List<Body> getBodies() => bodies;


    }
    //super fancy cool enum
    public enum Direction{
        up,
        down,
        left,
        right
    }
}
