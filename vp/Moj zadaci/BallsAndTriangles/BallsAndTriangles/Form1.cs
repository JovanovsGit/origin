using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsAndTriangles
{
    public partial class Form1 : Form
    {
        bool mouseDown = false;
        Ball b;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            Color color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            b = new Ball(e.Location,color);
            
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            try
            {
                b.isSelected = b.isHit(e.X, e.Y);
            }
            catch(Exception ex) { }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (mouseDown)
                {
                    b.Move(e.Location);
                    Invalidate();
                }
            }catch(Exception ex) { }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
           
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.Clear(Color.White);
                b.Draw(e.Graphics);
                
            }
            catch(Exception ex)
            {

            }
        }

       
    }
}
