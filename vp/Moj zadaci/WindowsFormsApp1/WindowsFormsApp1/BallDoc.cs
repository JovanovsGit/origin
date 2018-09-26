using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class BallDoc
    {
        public static int Velocity = 10;     
        public List<Ball> topcinja { get; set; }

        public int Width { get; set; }

        public int Hits { get; set; }

        public int Misses { get; set; }

        public BallDoc(int width)
        {
            topcinja = new List<Ball>();
            Width = width;
            Hits = 0;
            Misses = 0;
        }

        public void AddBall(Ball b)
        {
            topcinja.Add(b);
        }

        public void Draw(Graphics g)
        {
            foreach(Ball b in topcinja)
            {
                b.Draw(g);
            }
        }

        public void Move()
        {
            foreach (Ball b in topcinja)
            {
                b.Move(new Point(b.Center.X + Velocity, b.Center.Y));
                if (b.Center.X + Ball.Radius > Width)
                {
                    b.State = -1;
                    Misses++;
                }
                
            }
            for (int i = 0; i < topcinja.Count; i++)
            {
                if (topcinja[i].State == -1)
                {
                    topcinja.RemoveAt(i);
                }
            }
        }

        public void checkHit(int x, int y)
        {
            for(int i = 0; i < topcinja.Count; i++)
            {
                if (topcinja[i].isHit(x,y))
                {
                    topcinja[i].State++;
                }
            }

            for (int i = 0; i < topcinja.Count; i++)
            {
                if (topcinja[i].State == 3)
                {
                    Hits++;
                    topcinja.RemoveAt(i);
                }
            }
        }
    }
}
