using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shooter
{
    class Ship
    {
        public int X = 300;
        public int Y = 400;

        public int Speed = 5;
        public bool IsMovingRight = false;
        public bool IsMovingLeft = false;
        public bool IsMovingFront = false;
        public bool IsMovingBack = false;
        public void DrawShip(Graphics g, Pen p)
        {
            g.DrawLine(p, X, Y - 25, X - 25, Y + 10);
            g.DrawLine(p, X - 25, Y + 10, X + 25, Y + 10);
            g.DrawLine(p, X + 25, Y + 10, X, Y - 25);
            
            if(IsMovingLeft == true)
            {
                X = X - Speed;
            }
            if(IsMovingRight == true)
            {
                X = X + Speed;
            }
            if(IsMovingFront == true)
            {
                Y = Y - Speed;
            }
            if(IsMovingBack == true)
            {
                Y = Y + Speed;
            }
        }
    }
}
