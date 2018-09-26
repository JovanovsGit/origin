using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrashAvoidance
{
    public partial class Form1 : Form
    {
        private bool flag = true;
        private int count = 0;
        private int speed;
        private Random r;
        private PictureBox [] road = new PictureBox[8];
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            r = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            speed = 3;
            road[0] = pictureBox1;
            road[1] = pictureBox2;
            road[2] = pictureBox3;
            road[3] = pictureBox4;
            road[4] = pictureBox5;
            road[5] = pictureBox6;
            road[6] = pictureBox7;
            road[7] = pictureBox8;
            
        }

        private void RoadMover_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox pb in road)
            {
                pb.Top += 2;

                if(pb.Top >= this.Height)
                {
                    pb.Top = -pb.Height;
                }
            }
            if (CAR.Bounds.IntersectsWith(enemyCar1.Bounds))
            {
                gameOver();
            }
            if (CAR.Bounds.IntersectsWith(enemyCar2.Bounds))
            {
                gameOver();
            }
            if (CAR.Bounds.IntersectsWith(enemyCar3.Bounds))
            {
                gameOver();
            }
            if (CAR.Bounds.IntersectsWith(enemyCar4.Bounds))
            {
                gameOver();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                Right_mover.Start();
            }
            if(e.KeyCode == Keys.Left)
            {
                Left_mover.Start();
            }
        }

        private void Right_mover_Tick(object sender, EventArgs e)
        {
            if(CAR.Location.X < 502)
            CAR.Left += 7;
        }
        private void gameOver()
        {
            label1.Visible = true;
            RoadMover.Stop();
            Right_mover.Stop();
            Left_mover.Stop();
            enemy1_mover.Stop();
            enemy2_mover.Stop();
            enemy3_mover.Stop();
            enemy4_mover.Stop();
        }

        private void Left_mover_Tick(object sender, EventArgs e)
        {
            if(CAR.Location.X > 0)
            CAR.Left -= 7;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Right_mover.Stop();
            Left_mover.Stop();
        }

        private void enemy1_mover_Tick(object sender, EventArgs e)
        {
            enemyCar1.Top += 3;
            if (enemyCar1.Top >= this.Height)
            {
                int x = r.Next(1, 100);
                enemyCar1.Top = -enemyCar1.Height;
                enemyCar1.Left = x;
            }
        }

        private void enemy2_mover_Tick(object sender, EventArgs e)
        {
            enemyCar2.Top += 5;
            if (enemyCar2.Top >= this.Height)
            {
                if (count % 300 == 0)
                {
                    int x = r.Next(125, 225);
                    enemyCar2.Top = -enemyCar2.Height;
                    enemyCar2.Left = x;
                }
            }
        }

        private void enemy3_mover_Tick(object sender, EventArgs e)
        {
            enemyCar3.Top += 4;
            if (enemyCar3.Top >= this.Height)
            {
                int x = r.Next(250,350);
                enemyCar3.Top = -enemyCar3.Height;
                enemyCar3.Left = x;
            }
        }

        private void enemy4_mover_Tick(object sender, EventArgs e)
        {
            count++;
            enemyCar4.Top += 4;
            if (enemyCar4.Top >= this.Height)
            {
                if (count % 700 == 0)
                {
                    int x = r.Next(375, 490);
                    enemyCar4.Top = -enemyCar4.Height;
                    enemyCar4.Left = x;
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.ToUpper(e.KeyChar) == 'P')
            {
                if (flag)
                {
                    label2.Visible = true;
                    RoadMover.Stop();
                    Right_mover.Stop();
                    Left_mover.Stop();
                    enemy1_mover.Stop();
                    enemy2_mover.Stop();
                    enemy3_mover.Stop();
                    enemy4_mover.Stop();
                    flag = false;
                }
                else
                {
                    label2.Visible = false;
                    RoadMover.Start();
                    Right_mover.Start();
                    Left_mover.Start();
                    enemy1_mover.Start();
                    enemy2_mover.Start();
                    enemy3_mover.Start();
                    enemy4_mover.Start();
                    flag = true;
                }
            }
        }
    }
}
