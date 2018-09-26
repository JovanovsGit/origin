using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyBallOfChaose_Preresena
{
    public partial class Form1 : Form
    {

        private BallDoc ball;
        private Random r;
        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Start();
            this.DoubleBuffered = true;
            ball = new BallDoc();       // KOGA KE SE INICIJALIZIRA OVAJ KE SE INICIJALIZIRA I PRAZNA LISAT OD BLACK BALL   
            r = new Random();

            for(int i = 0; i < 4; i++)              // PUNAM JA LISTATA NA BLACK BALL ZATOA SO TAA TREBA DA E STATICKI
            {
                int bw = r.Next(2*BlackBall.Radius,this.Width - 2 * BlackBall.Radius);   // sirina
                int bh = r.Next(2*BlackBall.Radius,this.Height - 2 * BlackBall.Radius);   //  visina

                BlackBall bb = new BlackBall(bw,bh); // KREIRAM OBJEKT
                ball.AddBlackBall(bb);              // DODAVAM U LISTA
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            int dirX = r.Next(2);
            int dirY = r.Next(2);

            if (dirX == 0)
                dirX = -1;
            else
                dirX = 1;          // OVAA CELOTO E NA ACETO SMOTKO FINTA ZA PRAVECO

            if (dirY == 0)
                dirY = -1;
            else
                dirY = 1;
            Ball b = new Ball(e.Location,dirX,dirY);   // OBJEKT ZA CRVENI TOPKI
            ball.AddBall(b);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ball.Draw(e.Graphics);
            ball.DrawBlackBalls(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ball.isColiding();
            ball.BlackAndRedColiding();
            ball.Move(this.Width,this.Height);
            Invalidate();
        }
    }
}
