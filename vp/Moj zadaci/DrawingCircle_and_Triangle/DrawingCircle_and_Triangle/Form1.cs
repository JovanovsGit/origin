using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingCircle_and_Triangle
{
    public partial class Form1 : Form
    {
        public string shapeType { get; set; }
        public Color shapeColor;

        public Shape shape;
        public Shape tmpShape;
        public List<Shape> Shapess = new List<Shape>();

        public bool globalHit { get; set; }

        public Form1()
        {
            InitializeComponent();

            timer1.Start();

            circleToolStripMenuItem.Checked = true;
            shapeType = "Circle";
            shapeColor = Color.Green;
            this.DoubleBuffered = true;
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
            shapeType = "";
            if(sender == circleToolStripMenuItem)
            {
                circleToolStripMenuItem.Checked = true;
                rectangleToolStripMenuItem.Checked = false;
                shapeType = "Circle";
            }
            if(sender == rectangleToolStripMenuItem)
            {
                circleToolStripMenuItem.Checked = false;
                rectangleToolStripMenuItem.Checked = true;
                shapeType = "Rectangle";
            }
        }

        private void pickColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                shapeColor = colorDialog.Color;
            }

        }

  

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            shape = new Shape();
            shape.centar_x = e.X;
            shape.centar_y = e.Y;
            shape.radius = 30;
            shape.objColor = shapeColor;
            shape.typeName = shapeType;

            Shapess.Add(shape);

            Graphics g = this.CreateGraphics();
            shape.DrawShape(g, shapeType, shapeColor, e.X, e.Y);
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach(Shape ob in Shapess)
            {
                bool tmp = ob.isHit(e.X, e.Y);
                if (tmp)
                {
                    globalHit = true;
                    tmpShape = new Shape();
                    tmpShape = ob;

                    Graphics g = this.CreateGraphics();
                    Pen mypen = new Pen(Color.Red, 2);

                    if(tmpShape.typeName == "Circle")
                        g.DrawEllipse(mypen, ob.centar_x-30, ob.centar_y-30, 60, 60);
                    if(tmpShape.typeName == "Rectangle")
                        g.DrawRectangle(mypen, ob.centar_x - 30, ob.centar_y - 30, 60, 60);
                }
            }
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (globalHit)
            {
                Graphics g = this.CreateGraphics();
                Pen mypen = new Pen(Color.LightGray, 2);
                if (tmpShape.typeName == "Circle")
                    g.DrawEllipse(mypen, tmpShape.centar_x - 30, tmpShape.centar_y - 30, 60, 60);
                if (tmpShape.typeName == "Rectangle")
                    g.DrawRectangle(mypen, tmpShape.centar_x - 30, tmpShape.centar_y - 30, 60, 60);
            }
            globalHit = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (globalHit)
            {
                float dx = e.X - tmpShape.centar_x;
                float dy = e.Y - tmpShape.centar_y;
                tmpShape.centar_x += (int)dx;
                tmpShape.centar_y += (int)dy;
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            drawAll(Shapess, e.Graphics);

        }
        public void drawAll(List<Shape> lista,Graphics g)
        {
            foreach(Shape s in lista)
            {
                  s.DrawShape(g, s.typeName, shapeColor, s.centar_x, s.centar_y);  
            }
        }


    }
}