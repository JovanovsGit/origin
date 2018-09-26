using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elipses
{
    public partial class Form1 : Form
    {
        BallDoc ball;
        Ball b;
        bool link_MouseDownAndMouseMove = false;
        bool chekForFillElipse = false;
        public Form1()
        {
            InitializeComponent();
            ball = new BallDoc();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            chekForFillElipse = false;
            link_MouseDownAndMouseMove = true;
            b = new Ball(e.Location);
            ball.AddKrug(b);

           // Invalidate();      //   --   nesmee da go ima tuka u ovaj slucaj 
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            link_MouseDownAndMouseMove = false;
            chekForFillElipse = true;
            
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                
                if (chekForFillElipse)
                {
                    ball.FillElipse(e.Graphics);
                }
                else
                {
                    ball.DrawElipse(e.Graphics);
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (link_MouseDownAndMouseMove)
            {
                b.width = e.X - b.Center.X;
                b.height = e.Y - b.Center.Y;
                Invalidate();
            }
        }
    }
}
