using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_10
    {
        public Excersis_10()
        {
            Console.WriteLine("Adja meg hany deciliter");
            int num_a = Int32.Parse(Console.ReadLine());
            int hektoliter = num_a / 1000;
            int liter = (num_a - (hektoliter * 1000)) / 10;
            int deci = num_a - ((hektoliter * 1000) + (liter * 10));
            Console.WriteLine($"A megadott szam atvaltva {hektoliter} hektoliter, {liter} liter es {deci} deciliter.");
        }
    }
}
