using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBallOfChaos
{
    public partial class Form1 : Form
    {

        private BallDoc ball;

        public Form1()
        {
            InitializeComponent();
            ball = new BallDoc();
            timer1 = new Timer();
            timer1.Start();
            this.DoubleBuffered = true;
        }

        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ball.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            int dirX = r.Next(2);
            int dirY = r.Next(2);

            if (dirX == 0)
                dirX = -1;
            else
                dirX = 1;

            if (dirY == 0)
                dirY = -1;
            else
                dirY = 1;

            Ball b = new Ball(e.Location,dirX,dirY);             // isto kako new point  e.x e.y
            ball.topcinja.Add(b);
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Move(this.Height,this.Width);
            ball.isColiding();
            Invalidate();
        }
    }
}
