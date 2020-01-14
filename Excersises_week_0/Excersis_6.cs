using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_6
    {
        public Excersis_6()
        {
            Console.WriteLine("Igaz-else?");
            var igazE = Console.ReadLine();
            if (igazE == "true" || igazE == "True" || igazE == "igaz")
            {
                Console.WriteLine("IGAZ");
            }
        }
    }
}
