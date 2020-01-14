using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_18
    {
        public Excersis_18()
        {
            double ossz = 0;
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Adja meg a {i + 1}. honap homersekletet.");
                ossz += Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Az eves kozephomerseklet: {ossz / 12} Celsius.");
        }
    }
}
