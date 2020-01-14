using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_19
    {
        public Excersis_19()
        {
            int ossz = 60;
            Console.Write("Ker poharat? ");
            var pohar = Console.ReadLine();
            if (pohar == "nem")
            {
                ossz -= 10;
            }
            Console.Write("Dupla cukker? ");
            var cukker = Console.ReadLine();
            if (cukker == "igen")
            {
                ossz += 20;
            }
            Console.Write("Habosbabos? ");
            var habos = Console.ReadLine();
            if (habos == "igen")
            {
                ossz += 50;
            }
            Console.WriteLine($"A vegosszeg {ossz} Ft");
        }
    }
}
