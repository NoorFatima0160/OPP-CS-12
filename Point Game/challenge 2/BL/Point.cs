using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_2.BL
{
    class Point
    {
        public int x;
        public int y;
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;

        }

        public void setXY( int x ,int y)
        {
            this.x = x;
            this.y = y;

        }
        public int getX()
        {
            return x;
        }
        public void setX(int val)
        {
            x = val;
        }

        public int getY()
        {
            return x;
        }
        public void setY(int val)
        {
            x = val;
        }

    }
}
