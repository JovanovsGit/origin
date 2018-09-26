using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingLines
{
    public class Line
    {
        public Point start { get; set; }

        public Point end { get; set; }

        public Line(Point s, Point e)
        {
            start = s;
            end = e;
        }

        public void Draw(Graphics g)
        {
            Pen mypen = new Pen(Color.Black, 3);
            g.DrawLine(mypen, start, end);
            mypen.Dispose();
        }

    }
}
