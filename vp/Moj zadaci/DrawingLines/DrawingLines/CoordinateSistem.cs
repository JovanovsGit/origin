using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingLines
{
   public class CoordinateSistem      // OVAA MI E ZA KORDINATNIO POSLEDNO IDE
    {
        public Point Center { get; set; }

        public int width;

        public int height;

        public CoordinateSistem(Point center, int w, int h)
        {
            Center = center;
            width = w;
            height = h;
        }

        public void Draw(Graphics g)
        {
            Pen mypen = new Pen(Color.Pink, 1);
            g.DrawLine(mypen, Center.X, 0, Center.X, height);
            g.DrawLine(mypen, 0, Center.Y, width, Center.Y );
        }
    }
}
