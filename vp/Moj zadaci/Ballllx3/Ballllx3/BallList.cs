using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballllx3
{
    public class BallList
    {
        public List<Ball> topcinja;

        public BallList()
        {
            topcinja = new List<Ball>();
        }

        public void Draw(Graphics g)
        {
            foreach(Ball b in topcinja)
            {
                b.Draw(g);
            }
        }
        public void Move(Point c)
        {
            foreach (Ball b in topcinja)
            {
                if (b.isSelected)
                {
                    b.Move(c);
                }
            }
        }
        public void IsHit(int x, int y)
        {
            for(int i = topcinja.Count-1; i >= 0; i--)  // ------->> Ovaa e vaka za sekogas topceto so e odozgore, nego da mozam da go mrdam a ne toa odzdole <<<------
            {                                           //                  a topce odozgore e poslednoto iscrtano
                if (topcinja[i].IsHit(x, y))
                {
                    topcinja[i].isSelected = true;
                    break;
                }
            }
        }

        public void AddBall(Ball b)
        {
            topcinja.Add(b);
        }

        public void putFalse()                  // odselektiraj gi site topcinja so na mouseup
        {
            foreach(Ball b in topcinja)
            {
                b.isSelected = false;
            }
        }
    }
}
