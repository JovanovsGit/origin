using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Matematicka_igra
{
    public class Equation
    {
        public int op1 { get; set; }
        public int op2 { get; set; }
        public string operation { get; set; }
        


        public Equation()
        {
            GenerateRandom generator = new GenerateRandom();
            op1 = generator.getRandomOperand();
            op2 = generator.getRandomOperand();
            operation = generator.getRandomOperation();
        }

        public int trueResult()
        {
            if (operation == "+")
                return op1 + op2;
            if (operation == "-")
                return op1 - op2;
            if (operation == "*")
                return op1 * op2;
            if (operation == "/")
                return op1 / op2;
            else
            {
                return 0;  /// ovaj else go stavam zatoa so dava mi eror bez nego  t.e misle deka ima moznost da ne fleze u nieden if
            }
        }

    }
}
