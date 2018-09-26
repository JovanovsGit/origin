using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Matematicka_igra
{
    public class User
    {
        public string name { get; set; }
        public int userPoints { get; set; }

        public override string ToString()
        {
            return string.Format("Име: {0} - Поени: {1}", name, userPoints);
        }
    }
}
