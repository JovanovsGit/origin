using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elipses
{
    public class Ball
    {
        public int Radius { get; set; }

        public Point  Center { get; set; }

        public int width { get; set; }

        public int height { get; set; }

    

        public Ball(Point center)
        {
            Center = center;
            
        }

        public void FillElipse(Graphics g)
        {
            Brush br = new SolidBrush(Color.Red);
            g.FillEllipse(br, Center.X, Center.Y, width, height);
            br.Dispose();
            
        }

        public void DrawElipse(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawEllipse(p, Center.X, Center.Y, width, height);
            p.Dispose();
        }
    }
}
