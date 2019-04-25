using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    public class Block
    {
        public int width = 50;
        public int height = 25;

        public string x;
        public string y; 
        public string hp;
        public Color colour = Color.White;

        public static Random rand = new Random();

        public Block(string _x, string _y, string _hp)
        {
            x = _x;
            y = _y;
            hp = _hp;
        }
    }
}
