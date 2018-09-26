using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTickingPie
{
    public class PieDoc
    {
        public List<Pie> pies { get; set; }

        public PieDoc()
        {
            pies = new List<Pie>();
        }

        public void Draw(Graphics g)
        {
            foreach(Pie p in pies)
            {
                if(p.angle > 0)
                    p.Draw(g);
            }
        }

        public void AddPie(Pie p)
        {
            pies.Add(p);
        }

        public void EatPie()
        {
            foreach (Pie p in pies)
            {
                p.EatPie(p.angle - 45);
            }
        }
    }
}
