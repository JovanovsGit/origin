using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsAndTriangles
{
    public class Ball
    {
        public static int Radius = 30;

        public Point Center { get; set; }

        public Color color { get; set; }

        public bool isSelected { get; set; }

        public bool isFree { get; set; }

        public Ball(Point center, Color c)
        {
            Center = center;
            color = c;
        }

        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(color);
            g.FillEllipse(br, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);

            if (isSelected)
            {
                Pen P = new Pen(Color.Red, 2);
                g.DrawEllipse(P, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
                P.Dispose();
            }
           
            br.Dispose();
        }
     

        public void Move(Point center)
        {
            Center = center;
        }

        public bool isHit(int x, int y)
        {
            double d = Math.Sqrt(((Center.X - x) * (Center.X - x)) + ((Center.Y - y) * (Center.Y - y)));
            return d <= Radius;
        }
    }
}
