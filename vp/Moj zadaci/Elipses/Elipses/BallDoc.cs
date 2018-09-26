using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elipses
{
    public class BallDoc
    {
        public List<Ball> krugovi { get; set; }

        public BallDoc()
        {
            krugovi = new List<Ball>();
        }

        public void AddKrug(Ball b)
        {
            krugovi.Add(b);
        }

        public void FillElipse(Graphics g)
        {
            foreach (Ball b in krugovi)
            {
                    b.FillElipse(g);
            }
        }
        public void DrawElipse(Graphics g)
        {
            foreach (Ball b in krugovi)
            {
                    b.DrawElipse(g);
            }
        }
    }
}
