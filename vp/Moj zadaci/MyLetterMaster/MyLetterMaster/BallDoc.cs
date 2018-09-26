using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLetterMaster
{
    [Serializable]
    public class BallDoc
    {
        public List<Ball> topcinja { get; set; }

        public int hits = 0;
        public int misses = 0;  // ovie trebat za labelata dole

        public BallDoc()
        {
            topcinja = new List<Ball>();
            hits = 0;
            misses = 0;
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
                b.Move(new Point(b.Center.X, b.Center.Y + Ball.velocity));
            }
            for (int i = 0; i < topcinja.Count; i++)
            {
                if (topcinja[i].isPressed)
                    topcinja.RemoveAt(i);
            }
        }

        public void AddBall(Ball b)
        {
            topcinja.Add(b);
        }

        public void isHit(char c)
        {
            foreach(Ball b in topcinja)
            {
                if (b.isHit(c))
                {
                    b.isPressed = true;
                    hits++;
                }
            }
        }

        public void shouldDIE(int height)   // ---> ovaa e f-ja ako izleze od formata nadole
        {
            for(int i = 0; i < topcinja.Count; i++)
            {
                if(topcinja[i].Center.Y >= height - Ball.Radius * 2)
                {
                    topcinja.RemoveAt(i);
                    misses++;
                }
            }
        }

    }
}
