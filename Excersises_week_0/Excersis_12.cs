using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_12
    {
        public Excersis_12()
        {
            Console.WriteLine("Adjon meg egy pozitiv egesz szamot!");
            var input = Console.ReadLine();
            var numNumbers = 0;

            if (Int32.Parse(input) > 0)
            {
                foreach (var item in input)
                {
                    numNumbers++;
                }
                Console.WriteLine($"A megadott szam {numNumbers} szamjegyu.");
            }
            else
            {
                Console.WriteLine("Nem helyes a megadott ertek");
            }
        }
    }
}
