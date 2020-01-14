using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_15
    {
        public Excersis_15()
        {
            Console.WriteLine("Beszelsz angolul, spanyolul vagy magyarul?");
            var valasz = Console.ReadLine();

            if (valasz == "magyar")
            {
                Console.WriteLine("Szevasz!");
            }
            else if (valasz == "angol")
            {
                Console.WriteLine("Hello here!");
            }
            else if (valasz == "spanyol")
            {
                Console.WriteLine("Buenos dias!");
            }
            else
            {
                Console.WriteLine("\u2665");
            }

        }
    }
}
