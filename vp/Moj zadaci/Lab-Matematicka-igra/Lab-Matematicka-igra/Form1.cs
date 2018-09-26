using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Matematicka_igra
{
    public partial class Form1 : Form
    {
        private string message = ""; // used for MessageBox
        private string caption = ""; // used for MessageBox

        public static int TIME = 60;

        public int timeElapsed = TIME;

        public Equation equation;

        public List<User> users = new List<User>();

        public User player;

        public int userResult { get; set; }

        public int risePoints { get; set; }

        public Form1()
        {
            InitializeComponent();
            newGame();
        }

        public void newGame()
        {
            player = new User();

            risePoints = 0;
            lblPoints.Text = risePoints.ToString();

            txtName.Text = "";

            /////////////////////////////////////////////////////
            pbPoints.Minimum = 0;
            pbPoints.Maximum = 30;
            pbPoints.Value = risePoints;
                                             //  setiranje max i min na progres barovite
            pbTime.Minimum = 0;
            pbTime.Maximum = 60;
            pbTime.Value = TIME;
            /////////////////////////////////////////////////////

            timeElapsed = TIME;

            GenerateNewEquation();

            timer1.Start();
        }

        public void endGame()
        {
            timer1.Stop();
            DialogResult res = MessageBox.Show("Дали сакате да ја исклучете играта?", "Игра", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                timer1.Start();
            }
        }

        public void GenerateNewEquation()
        {
            equation = new Equation();
            txtOperant1.Text = equation.op1.ToString();
            txtOperant2.Text = equation.op2.ToString();
            txtOperation.Text = equation.operation.ToString();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                timer1.Stop();
                message = "Немате внесено играч";
                caption = "Грешка";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnswer.Clear();
                timer1.Start();
                return;
            }
            else if (txtAnswer.Text.Length == 0)
            {
                timer1.Stop();
                message = "Немате внесено резултат";
                caption = "Грешка";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnswer.Clear();
                timer1.Start();
                return;
            }

            if (!int.TryParse(txtAnswer.Text, out int result))
            {
                timer1.Stop();
                message = "Невалиден формат на резултатот";
                caption = "Грешка";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnswer.Clear();
                timer1.Start();
                return;
            }

            userResult = Convert.ToInt32(txtAnswer.Text);

            if (userResult == equation.trueResult())
            {
                risePoints++;
                pbPoints.Value = risePoints;
                lblPoints.Text = risePoints.ToString();
            }

            if(risePoints % 5 == 0 && risePoints != 0)
            {
                if (timeElapsed + 5 > TIME)
                {
                    timeElapsed = TIME;
                    pbTime.Value = TIME;
                }
                else
                {
                    timeElapsed += 5;
                    pbTime.Value = timeElapsed;
                }
                
            }

            txtAnswer.Text = "";
            GenerateNewEquation();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed--;
            pbTime.Value = timeElapsed;

            lblTime.Text = string.Format("{0}:{1}", timeElapsed / 60, timeElapsed % 60);

            if(timeElapsed == 0)
            {
                timer1.Stop();
                endGame();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            player.name = txtName.Text;
            player.userPoints = Convert.ToInt32(lblPoints.Text);
            users.Add(player);

            newGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            endGame();
        }

        private void btnBestPlayers_Click(object sender, EventArgs e)
        {
            player.name = txtName.Text;
            player.userPoints = Convert.ToInt32(lblPoints.Text);
            users.Add(player);

            users = users.OrderByDescending(x => x.userPoints).ToList();

            BestPlayer igrac = new BestPlayer();
            igrac.igraci = users;
            igrac.fill();
            igrac.ShowDialog();

           
        }
    }
}
