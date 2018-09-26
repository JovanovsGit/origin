using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingCircle_and_Triangle
{
    public class Shape
    {
        public string typeName { get; set; }
        public int centar_x { get; set; }
        public int centar_y { get; set; }
        public Color objColor { get; set; }
        public int radius { get; set; }

            
        public void DrawShape(Graphics g ,string shapeType, Color shapeColor,int x,int y)
        {
            if(shapeType == "Circle")
            {
                
                SolidBrush br = new SolidBrush(shapeColor);
               // Pen pen = new Pen(Color.Red, 2);

                g.FillEllipse(br, x - radius, y - radius, 60, 60);
               // g.DrawEllipse(pen, x - 30, y - 30, 60, 60);

               // pen.Dispose();
                br.Dispose();
            }
            if(shapeType == "Rectangle")
            {
                SolidBrush br = new SolidBrush(shapeColor);
               // Pen pen = new Pen(Color.Red, 2);

                g.FillRectangle(br, x - radius, y - radius, 2*radius, 2*radius);
              //  g.DrawRectangle(pen, x - 30, y - 30, 60, 60);

              //  pen.Dispose();
                br.Dispose();
            }
        }
        public bool isHit(float x, float y)
        {
            if (Math.Sqrt(((centar_x - x) * (centar_x - x)) + ((centar_y - y) * (centar_y - y))) <= radius)
            {
                return true;
            }
            else return false;
        }

    }
}
