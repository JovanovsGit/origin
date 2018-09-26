using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBallOfChaose_Preresena
{
    public class BlackBall
    {
        public int x { get; set; }          // --->>> OVAA KLASA JA PRAVAM POSLEDNA 

        public int y { get; set; }          // --->>> PRV SI GI PRAVAM SITE RABOTI ZA CRVENOTO TOPCE

        public static int Radius = 35;

        public BlackBall(int a, int b)
        {
            x = a;
            y = b;
        }

        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(Color.Black);
            g.FillEllipse(br, x - Radius, y - Radius, 2 * Radius, 2 * Radius);
            br.Dispose();
        }

        public bool isColiding(Ball ball)
        {
            double d = Math.Sqrt(((x - ball.Center.X) * (x - ball.Center.X)) + ((y - ball.Center.Y) * (y - ball.Center.Y)));
            return d <= Radius + Ball.Radius ;
        }
    }
}
