using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ballllx3
{
    public partial class Form1 : Form
    {
        BallList ballList;
        Ball b;
        bool isMouseDown;

        public Form1()
        {
            InitializeComponent();
            ballList = new BallList();
            this.DoubleBuffered = true;
            isMouseDown = false;
        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();            ///////// ---->>>>> GENERIRANJE NA RANDOM BOJA <<<<--------
            Color color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            b = new Ball(e.Location, color);
            ballList.AddBall(b);
            Invalidate();
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                ballList.Move(e.Location);
            }
            Invalidate();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            ballList.IsHit(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            ballList.putFalse();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ballList.Draw(e.Graphics);
        }

    }
}
