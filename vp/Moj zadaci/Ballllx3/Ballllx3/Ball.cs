using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballllx3
{
    public class Ball
    {
        public Point Center { get; set; }

        public static int Radius = 30;

        public Color color;

        public bool isSelected { get; set; }

        public Ball(Point center, Color c)
        {
            Center = center;
            color = c;
        }

        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(color);
            g.FillEllipse(br, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            if (isSelected)              //   ------->>>>> Ovaa e ovde za crveoto iscrtuvanje   <<<<----------  //
            {
                Pen mypen = new Pen(Color.Red, 2);
                g.DrawEllipse(mypen, Center.X - Ball.Radius, Center.Y - Ball.Radius, 2 * Ball.Radius, 2 * Ball.Radius);
                mypen.Dispose();
            }
            br.Dispose();
        }

        public void Move(Point c)
        {
            Center = c;
        }

        public bool IsHit(int x, int y)
        {
            double d = Math.Sqrt((Center.X - x) * (Center.X - x) + (Center.Y - y) * (Center.Y - y));

            return d <= Radius;
        }
    }
}
