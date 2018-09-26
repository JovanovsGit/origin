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

namespace MyLetterMaster
{
    public partial class Form1 : Form
    {
        private string FileName;// ---->>>> OVAA E POTREBNO ZA SERELIZACIJA
        private BallDoc ball;   // DRUGITE 2 KLASI ODOZGORE TREBA DA IMAT [Serializable]
        private Random r;
        private int Count;
        private bool pause;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            ball = new BallDoc();
            this.DoubleBuffered = true;
            r = new Random();
            FileName = null;
            pause = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ball.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Count++;
            if (Count % 20 == 0)        // ovaa e za da ne geneirira mn brzo topcinja. Na sekoj 20 tick
            {
                int x = r.Next(2*Ball.Radius,this.Width - 2*Ball.Radius);
                int y = 0 - 2 * Ball.Radius;
                char letter = (char)((int)'A' + r.Next(26));
                Ball b = new Ball(new Point(x, y), letter);
                ball.AddBall(b); 
            }
            ball.Move();
            ball.shouldDIE(this.Height);
            Invalidate(true);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ball.isHit(Char.ToUpper(e.KeyChar));
            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = "Hits: " + ball.hits.ToString();
            toolStripStatusLabel2.Text = "Misses: " + ball.misses.ToString();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ball = new BallDoc();
        }

            private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (FileName == null)
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "Ball flying docs (*.bfd)|*.bfd";
                    dialog.Title = "Save your flying doc";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        FileName = dialog.FileName;
                    }
                    try
                    {
                        using (FileStream stream = new FileStream(FileName, FileMode.Create))
                        {
                            var formatter = new BinaryFormatter();
                            formatter.Serialize(stream, (BallDoc)ball);
                            FileName = null;
                        }

                    }
                    catch (Exception ex)
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
                            ball = (BallDoc)formatter.Deserialize(stream);

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

            if (pause == false)
            {
                pauseToolStripMenuItem.Text = "Continue";
                pause = true;
                timer1.Stop();
            }
            else
            {
                pauseToolStripMenuItem.Text = "Pause";
                pause = false;
                timer1.Start();
            }

        }
    }
}
