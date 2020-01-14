using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_4
    {
        public Excersis_4()
        {
            Console.WriteLine("Adjon meg egy szamot");
            var num_a = Int32.Parse(Console.ReadLine());
            if (num_a < 0)
            {
                Console.WriteLine("A szam negativ!");
            }
            else
            {
                Console.WriteLine("A szam pozitiv");
            }
        }
    }
}
