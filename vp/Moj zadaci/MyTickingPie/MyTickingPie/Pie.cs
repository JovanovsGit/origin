using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTickingPie
{
    public class Pie
    {
        public Point Center { get; set; }

        public static int Radius = 30;


        public int angle { get; set; }

        public Pie(Point c, int a)
        {
            Center = c;
            angle = a;
        }

        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(Color.Blue);
            g.FillPie(br, Center.X - Radius, Center.Y - Radius, 2*Radius, 2*Radius, 0, angle);
            br.Dispose();
        }

        public void EatPie(int a)
        {
            angle = a;
        }
    }
}
