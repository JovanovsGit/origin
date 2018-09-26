using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingLines
{
    public partial class Form1 : Form
    {
       
        private LineDoc ln;
        private Line line;
        private Random r;
        private Point tmp;
        CoordinateSistem cr;
 

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            ln = new LineDoc();
            r = new Random();
            int x = r.Next(this.Width);
            int y = r.Next(this.Height);
            line = new Line(new Point(x, y), new Point());
            // ovaa e generiranje na prva tocka random i vtora prazna
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
                line.end = e.Location;
                tmp = line.end;
                ln.lines.Add(line);
                Invalidate(true);
            
            line = new Line(tmp, new Point());
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ln.Draw(e.Graphics);
            try
            { 
                cr.Draw(e.Graphics);
            }catch(Exception ex)
            {

            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            cr = new CoordinateSistem(e.Location, this.Width, this.Height);
            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            try {
                toolStripStatusLabel1.Text = "Number of lines: " + ln.lines.Count.ToString();
                toolStripStatusLabel2.Text = "X: " + cr.Center.X.ToString();
                toolStripStatusLabel3.Text = "Y: " + cr.Center.Y.ToString();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
