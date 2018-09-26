using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBallOfChaose_Preresena
{
    public class BallDoc
    {
        public List<Ball> topcinja { get; set; }
        public List<BlackBall> blackBalls{ get; set; } //2

        public BallDoc()
        {
            topcinja = new List<Ball>();
            blackBalls = new List<BlackBall>();    /// BITEN E ZA DA GI POVRZAM CRNITE TOPCINJA
        }
        public void AddBlackBall(BlackBall bb)    /// DODAVANJE NA CRNI TOPCINJA U LISTA
        {
            blackBalls.Add(bb);
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
        public void Move(int sirina,int visina)
        {
            foreach(Ball b in topcinja)
            {
                b.Move(new Point(b.Center.X + b.velocityX * b.directionX, b.Center.Y + b.velocityY * b.directionY));

                if(b.Center.X + 2 * Ball.Radius >= sirina)
                {
                    b.velocityX = b.velocityX * -1; 
                }
                if (b.Center.Y + 3 * Ball.Radius >= visina)      ///----->>> TUKA SE ODBIVAT TOPCINJA OD KRAEVITE
                {
                    b.velocityY = b.velocityY * -1;
                }
                if (b.Center.Y - Ball.Radius <= 0)
                {
                    b.velocityY = b.velocityY * -1;
                }
                if (b.Center.X - Ball.Radius <= 0)
                {
                    b.velocityX = b.velocityX * -1;
                }
            }
        }
        //public void isColiding()              ////// ----->>>> OVAA E FUNKCIJA AKO TREBA CRVENO SO CRVENO DA SE SUDRE
        //{
        //    if (topcinja.Count > 1)
        //    {
        //        for (int i = 0; i < topcinja.Count - 1; i++)
        //        {
        //            for (int j = i + 1; j < topcinja.Count; j++)
        //            {
        //                if (topcinja[i].isColiding(topcinja[j]))
        //                {
        //                    topcinja[i].isColided = true;
        //                    topcinja[j].isColided = true;
        //                }
        //            }
        //        }
        //        for (int i = topcinja.Count - 1; i >= 0; i--)
        //        {
        //            if (topcinja[i].isColided)
        //            {
        //                topcinja.RemoveAt(i);
        //            }
        //        }
        //    }
        //}
        public void DrawBlackBalls(Graphics g)
        {
            foreach(BlackBall bb in blackBalls)
            {
                bb.Draw(g);
            }
        }
        public void BlackAndRedColiding()
        {
            if (topcinja.Count > 0)
            {
                for (int i = 0; i < blackBalls.Count; i++)
                {
                    for (int j = 0; j < topcinja.Count; j++)
                    {
                        if (blackBalls[i].isColiding(topcinja[j]))
                        {
                            topcinja[j].isColided = true;
                        }
                    }
                }
                for (int i = topcinja.Count - 1; i >= 0; i--)
                {
                    if (topcinja[i].isColided)
                    {
                        topcinja.RemoveAt(i);
                    }                               //////---->>> TUKA ZAVRSUVA COCE  NADOLE E SAMO ZAGRADI <3
                }
            }
        }
    }
}
