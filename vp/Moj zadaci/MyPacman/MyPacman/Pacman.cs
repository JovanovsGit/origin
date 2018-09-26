using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPacman
{
   public class Pacman
    {

        public int X { get; set; }
        public int Y { get; set; }
        public static int radius = 20;
        public int speed = radius;
        public DIRECTION d { get; set; }
        public bool mouthStatus { get; set; }

        Brush b = new SolidBrush(Color.Yellow);

        public enum DIRECTION
        {
            left,
            right,
            up,
            down
        }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public Pacman()                 // konstruktor
        {
            speed = radius;
            X = 7;                      
            Y = 5;
            d = DIRECTION.right;
            mouthStatus = false;
        }

        public void ChangeDirection(DIRECTION direction)
        {
            d = direction;
        }

        public void Move(int x,int y)
        {
            if (mouthStatus == false)
                mouthStatus = true;
            else
                mouthStatus = false;
            if (d == DIRECTION.right)
            {
                if (X == x - 1)
                {
                    X = 0;
                }
                else X++;
            }
            else
     if (d == DIRECTION.left)
            {
                if (X == 0)
                {
                    X = x - 1;
                }
                else X--;
            }
            else
     if (d == DIRECTION.down)
            {
                if (Y == y - 1)
                {
                    Y = 0;
                }
                else Y++;
            }
            else
     if (d == DIRECTION.up)
            {
                if (Y == 0)
                {
                    Y = y - 1;
                }
                else Y--;
            }
        }
    

        public void Draw(Graphics g)
        {
            if(mouthStatus == false)
            {
                g.FillEllipse(b, X, Y, 2 * radius, 2 * radius);
            }
            else
            {
                g.FillPie(b, X, Y, radius*2, radius*2, 45, 270);
            }
        }   


    }
}
