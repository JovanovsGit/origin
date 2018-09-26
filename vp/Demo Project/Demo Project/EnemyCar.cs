using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project
{
    public class EnemyCar
    {
        public Point Center { get; set; }
        public static int width = 75;
        public static int height = 95;
        public int velocity;

        public EnemyCar(Point c, int v)
        {
            Center = c;
            velocity = v;
        }

        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(Color.Red);
            g.FillRectangle(br, Center.X, Center.Y, width, height);
            br.Dispose();
        }

        public void Move(Point c)
        {
            Center = c;
        }

        public bool IsHit(HeroCar he)
        {
            double d = Math.Sqrt((Center.X - he.Center.X) * (Center.X - he.Center.X) + (Center.Y - he.Center.Y) * (Center.Y - he.Center.Y));

           return d <= EnemyCar.height+4;
        }
    }
}
