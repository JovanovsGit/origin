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
    public partial class BestPlayer : Form
    {
        public List<User> igraci = new List<User>();

        public void fill()
        {
            foreach (User u in igraci)
            {
                lstBestPlayers.Items.Add(u);
            }
        }
         
        public BestPlayer()
        {
            InitializeComponent();
        }
        
      
    }
}
