using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBallOfChaose_Preresena
{
    public class Ball
    {
        public int directionX { get; set; }

        public int directionY { get; set; }

        public static int Radius = 20;

        public int velocityX = 5;

        public int velocityY = 5;

        public Point  Center { get; set; }

        public bool isColided { get; set; }

        public Ball(Point center, int dx, int dy)
        {
            directionX = dx;
            directionY = dy;
            Center = center;
            isColided = false;
        }

        

        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(Color.Red);
            g.FillEllipse(br, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
        }

        public void Move(Point center)
        {
            Center = center;
        }

        public bool isColiding(Ball ball)
        {
            double d = Math.Sqrt(((Center.X - ball.Center.X) * (Center.X - ball.Center.X)) + ((Center.Y - ball.Center.Y) * (Center.Y - ball.Center.Y)));
            return d <= Radius * 2;
        }
    }
}
