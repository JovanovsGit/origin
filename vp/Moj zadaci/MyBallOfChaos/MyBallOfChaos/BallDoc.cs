using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBallOfChaos
{
    public class BallDoc
    {
        public List<Ball> topcinja { get; set; }

        public int Hits { get; set; }

        public int currentState { get; set; }

        public bool checkBreak = false;


        public BallDoc()
        {
            topcinja = new List<Ball>();
            Hits = 0;
            currentState = 0;
        }

        public void Draw(Graphics g)
        {
            foreach (Ball b in topcinja)
            {
                b.Draw(g);
            }
        }

        public void AddBall(Ball b)
        {
            topcinja.Add(b);
        }

        public void Move(int h, int w)
        {
            foreach(Ball b in topcinja)
            {
                b.Move(new Point(b.Center.X + b.velocityX * b.directionX, b.Center.Y + b.velocityY * b.directionY));

                if(b.Center.X + 2 *Ball.Radius >= w)
                {
                    b.velocityX = b.velocityX * -1;
                }
                if (b.Center.Y + 3 * Ball.Radius >= h)              // 3 apwoksfapwfaosfapw wtfff
                {
                    b.velocityY = b.velocityY * -1;
                }
                if(b.Center.X  - Ball.Radius <= 0)
                {
                    b.velocityX = b.velocityX * -1;
                }
                if (b.Center.Y - Ball.Radius <= 0)
                {
                    b.velocityY = b.velocityY * -1;
                }
            }
        }

        public void isColiding()
        {
            if (topcinja.Count > 1)
            {
                for (int i = 0; i < topcinja.Count; i++)
                {
                    for (int j = i + 1; j < topcinja.Count; j++)
                    {
                        if (topcinja[i].isColiding(topcinja[j]))
                        {
                            topcinja[i].isColided = true;
                            topcinja[j].isColided = true;
                        }
                    }
                }
            }

            for (int i = topcinja.Count-1; i >= 0; i--)
            {
                if (topcinja[i].isColided)
                {
                    topcinja.RemoveAt(i);
                }
            }
        }
    }
}
