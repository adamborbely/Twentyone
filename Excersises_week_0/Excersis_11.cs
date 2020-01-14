using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_11
    {
        public Excersis_11()
        {
            Console.WriteLine("Adj meg egy szamot, elmondom oszthato-e kilenccel");
            var input = Console.ReadLine();
            int sumInput = 0;

            foreach (var caracter in input)
            {
                sumInput += Int32.Parse(caracter.ToString());
            }
            Console.WriteLine($"A szamjegyek osszege: {sumInput}");
            if (Int32.Parse(input) % 9 == 0)
            {
                Console.WriteLine("Oszthato 9-el");
            }
            else
            {
                Console.WriteLine("Nem oszthato 9-el");

            }
        }
    }
}
