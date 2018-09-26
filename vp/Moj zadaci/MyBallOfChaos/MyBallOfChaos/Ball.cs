using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBallOfChaos
{
    public class Ball
    {
        public  int velocityX = 5;

        public  int velocityY = 5;

        public static int Radius = 20;

        public bool isColided { get; set; }

        public Point Center { get; set; }

        public int directionX { get; set; }

        public int directionY { get; set; }


        public Ball(Point center,int dirX,int dirY)
        {
            Center = center;
            directionX = dirX;
            directionY = dirY;
        }

        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(Color.Black);
            g.FillEllipse(br, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            br.Dispose();
        }

        public void Move(Point newCenter)
        {
            Center = newCenter;
        }

        public bool isColiding(Ball ball)
        {
            double d = Math.Sqrt(((Center.X - ball.Center.X) * (Center.X - ball.Center.X)) + ((Center.Y - ball.Center.Y) * (Center.Y - ball.Center.Y)));
            return d <= 10+Radius;
        }

    }
}
