using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project
{
    public class HeroCar
    {
        public  Point Center { get; set; }
        public static int width = 70;
        public static int height = 90;
        public int velocity = 12;

        public HeroCar(Point c)
        {
            Center = c;
        }

        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(Color.Blue);
            g.FillRectangle(br, Center.X, Center.Y, width, height);
            br.Dispose();
        }

        public void Move(Point c)
        {
            Center = c;
        }

        //public bool IsHit(int x, int y)
        //{
        //    double d = Math.Sqrt((Center.X - x) * (Center.X - x) + (Center.Y - y) * (Center.Y - y));

        //    return d <= Radius;
        //}
    }
}
