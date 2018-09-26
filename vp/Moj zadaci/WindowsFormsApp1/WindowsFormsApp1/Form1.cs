using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string FileName;
        private BallDoc ballDoc;
        private int timerCall;
        private bool isPaused;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            timerCall = 0;
            ballDoc = new BallDoc(this.Width);
            timer1 = new Timer();
            timer1.Start();
            this.DoubleBuffered = true;
            FileName = null;
            isPaused = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isPaused == false)
            {
                if (timerCall % 10 == 0)
                {

                    var randomY = r.Next(2 * Ball.Radius, this.Height - (2 * Ball.Radius));
                    Ball b = new Ball(new Point(-Ball.Radius, randomY));
                    ballDoc.AddBall(b);
                }

                ballDoc.Move();
                Invalidate(true);
                timerCall++;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ballDoc.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            ballDoc.checkHit(e.X, e.Y);
            Invalidate(true);
        }
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            try
            {
                ballDoc.Width = this.Width;
                Invalidate(true);
            }
            catch(Exception ex)
            {
                
            }
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Hits: {0}", ballDoc.Hits);
            toolStripStatusLabel2.Text = string.Format("Misses: {0}", ballDoc.Misses);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ballDoc = new BallDoc(this.Width);
        }
      
        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FileName == null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Ball flying docs (*.bfd)|*.bfd";
                dialog.Title = "Save your flying doc";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = dialog.FileName;
                }
                try
                {
                    using(FileStream stream = new FileStream(FileName,FileMode.Create))
                    {
                        var formatter = new BinaryFormatter();
                        formatter.Serialize(stream, (BallDoc)ballDoc);
                        FileName = null;
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error while saving  the file");
                }

            }
        }

        private void openGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Ball flying docs (*.bfd)|*.bfd";
                dialog.Title = "Open your flying doc";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = dialog.FileName;
                }
                try
                {
                    using (FileStream stream = new FileStream(FileName, FileMode.Open))
                    {
                        var formatter = new BinaryFormatter();
                       ballDoc = (BallDoc)formatter.Deserialize(stream);
                        
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while saving  the file");
                }

            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(isPaused == false)
            {
                pauseToolStripMenuItem.Text = "Continue";
                isPaused = true;
            }
            else
            {
                pauseToolStripMenuItem.Text = "Pause";
                isPaused = false;
            }
        }
    }
}
