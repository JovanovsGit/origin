using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Project
{
    public partial class Form1 : Form
    {
        private CarList car;
        private Random r;
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
            r = new Random();

            HeroCar h = new HeroCar(new Point(this.Width / 2, this.Height - 2*HeroCar.height));
            car = new CarList();
            car.AddHero(h);
            
            
            timer1.Start();
            this.DoubleBuffered = true;
                 
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            count++;
            if (count % 35 == 0)        
            {
                int x = r.Next( EnemyCar.width, this.Width - EnemyCar.width);
                int y = 0 - EnemyCar.height;
                int v = r.Next(5, 10);

                EnemyCar en = new EnemyCar(new Point(x, y),v);
                car.AddEnemy(en);
            }
            
            car.Move();
            car.IsHit();
            if (car.flag)
                timer1.Stop();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            car.DrawHero(e.Graphics);
            car.Draw(e.Graphics);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            car.MoveHero((Char.ToUpper(e.KeyChar)));
        }
    }
}
