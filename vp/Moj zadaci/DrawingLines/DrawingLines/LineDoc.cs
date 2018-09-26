using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingLines
{
    public class LineDoc
    {
        public List<Line> lines;

        public LineDoc()
        {
            lines = new List<Line>();
        }

        public void Draw(Graphics g)
        {
            foreach(Line l in lines)
            {
                l.Draw(g);
            }
        }

        public void add(Line l)
        {
            lines.Add(l);
        }
    }
}
