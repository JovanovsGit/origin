using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Matematicka_igra
{
    public class GenerateRandom
    {
        Random random = new Random();
        string[] niza = { "+", "-", "*", "/" };

       public GenerateRandom()
        {

        }
        public int getRandomOperand()
        {
            return random.Next(1,11);
        }
        public string getRandomOperation()
        {
            return niza[random.Next(niza.Length)];
        }

    }
}
