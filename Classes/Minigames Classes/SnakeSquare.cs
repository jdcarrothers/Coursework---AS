using System;
using System.Collections.Generic;
using System.Text;

namespace Coursework_0._0
{
    class SnakeSquare
    {
        private int x;
        private int y;

        public SnakeSquare()
        {
            Random r = new Random();
            X = (r.Next(0, 39));
            Y = (r.Next(0, 20));
        }

        public SnakeSquare(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
