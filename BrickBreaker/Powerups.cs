using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    class Powerups
    {
        public int x, y, speed;
        public string type;
        public int width = 15;
        public int height = 15;

        public Powerups(int _x, int _y, int _speed, string _type)
        {
            x = _x;
            y = _y;
            speed = _speed;
            type = _type;
        }

        public void powerupMove()
        {
            y += speed;
        }

        public bool PowerupCollision()
        {
            Rectangle paddleR = new Rectangle(GameScreen.paddle.x, GameScreen.paddle.y, GameScreen.paddle.width, GameScreen.paddle.height);
            Rectangle powerupR = new Rectangle(x, y, width, height);

            if (powerupR.IntersectsWith(paddleR))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
