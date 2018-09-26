using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHangManWorld
{
    public partial class Form1 : Form
    {

        private HangManWorld game;
        private static readonly int TIME = 60 * 10;
        private int timeElapsed;

        public Form1()
        {
            InitializeComponent();
            newGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed--;
            pbTime.Value = timeElapsed;
            pbWrong.Value = game.pogresniObidi;

            lblTimer.Text = string.Format("{0:00}:{1:00}", timeElapsed/60, timeElapsed%60);

            if(timeElapsed == 0 || game.pogresniObidi == HangManWorld.maxObidi)
            {
                endGame();
                return;
            }
            lblMask.Text = game.MaskWord();
            txtPogodeniBukvi.Text = game.getAllLetters();

        }

        public void newGame()
        {
            game = new HangManWorld("mqcedonia");
            timer1.Start();

            timeElapsed = TIME;

            pbTime.Minimum = 0;
            pbTime.Maximum = TIME;
            pbTime.Value = TIME;

            pbWrong.Minimum = 0;
            pbWrong.Maximum = HangManWorld.maxObidi;
        }
        
        public void endGame()
        {
            timer1.Stop();
            lblMask.Text = game.Word;
            MessageBox.Show("igrata zavrsi");
            DialogResult res = MessageBox.Show("dali sakate nova igra", "igra", MessageBoxButtons.YesNo);
            if(res == System.Windows.Forms.DialogResult.Yes)
            {
                newGame();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            if (!game.GuessLetter(Convert.ToChar(txtBukva.Text))) // pri konvertiranje e go zeme samo prviot zbor
            {
                MessageBox.Show("veke vnesena bukva");
                txtBukva.Text = "";
            }
            else
            {
                txtBukva.Text = "";
                pbWrong.Value = game.pogresniObidi;
                lblMask.Text = game.MaskWord();
                txtPogodeniBukvi.Text = game.getAllLetters();

            }
        }
    }
}
