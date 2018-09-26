using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTickingPie
{
    public partial class Form1 : Form
    {
        PieDoc pieDoc;
        private bool pause;

        public Form1()
        {
            InitializeComponent();
            
            pieDoc = new PieDoc();
            this.DoubleBuffered = true;
            pause = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pieDoc.EatPie();
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Pie p = new Pie(e.Location, 360);
            pieDoc.AddPie(p);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            pieDoc.Draw(e.Graphics);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (pause == false)
            {
                startToolStripMenuItem.Text = "Pause";
                pause = true;
                timer1.Start();
            }
            else
            {
                startToolStripMenuItem.Text = "Start";
                pause = false;
                timer1.Stop();
            }
        }
    }
}
