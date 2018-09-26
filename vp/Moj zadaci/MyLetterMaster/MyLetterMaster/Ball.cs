using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLetterMaster
{
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }

        public static int Radius = 30;

        public static int velocity = 5;

        public char letter;

        public bool isPressed { get; set; }

        public Ball(Point c, char l)
        {
            Center = c;
            letter = l;
        }

        public void Draw(Graphics g)
        {
            Brush br = new SolidBrush(Color.LightGreen);
            g.FillEllipse(br, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);

            Font f = new Font("Ariel", 24);
            g.DrawString(string.Format("{0}", letter), f, Brushes.Black, Center.X - (Radius / 2), Center.Y - (Radius / 2));
            br.Dispose();

            if (isPressed)
            {
                Brush b = new SolidBrush(Color.Red);
                g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            }
        }

        public void Move(Point c)
        {
            Center = c;
        }

        public bool isHit(char c)
        {
            return c == letter;
        }
    }
}
