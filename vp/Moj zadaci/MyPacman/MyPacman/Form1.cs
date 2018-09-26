using MyPacman.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPacman
{
    public partial class Form1 : Form
    {

        Timer timer;
        Pacman pacman;
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 15;
        Image foodImage;
        bool[][] foodWorld;

        public Form1()
        {
            InitializeComponent();
            // Vcituvanje na slika od resursi
            foodImage = Resources.go;
            DoubleBuffered = true;
            newGame();
        }

        public void newGame()
        {
            pacman = new Pacman();
            this.Width = Pacman.radius * 2 * (WORLD_WIDTH + 1);
            this.Height = Pacman.radius * 2 * (WORLD_HEIGHT + 1);
            // овде кодот за иницијализација на матрицата foodWorld

            foodWorld = new bool[WORLD_WIDTH][];
            for (int i = 0; i < WORLD_WIDTH; i++)
            {
                foodWorld[i] = new bool[WORLD_HEIGHT];
                for (int j = 0; j < WORLD_HEIGHT; j++)
                    foodWorld[i][j] = true;
            }
            // овде кодот за иницијализација и стартување на тајмерот
            timer = new Timer();
            timer.Interval = TIMER_INTERVAL;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }

        void timer_Tick(object sender, EventArgs e)
        {
            // овде вашиот код
            for (int i = 0; i < WORLD_WIDTH; i++)
            {
                for (int j = 0; j < WORLD_HEIGHT; j++)
                {

                    foodWorld[pacman.X][pacman.Y] = false;

                }
            }

            pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);
            Invalidate();
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    if (foodWorld[i][j])
                    {
                        g.DrawImageUnscaled(foodImage, j * Pacman.radius * 2 + (Pacman.radius * 2 - foodImage.Height) / 2, i * Pacman.radius * 2 + (Pacman.radius * 2 - foodImage.Width) / 2);
                    }
                }
            }
            pacman.Draw(g);
        }
    }
}
