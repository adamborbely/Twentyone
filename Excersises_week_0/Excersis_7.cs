using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_7
    {
        public Excersis_7()
        {
            Console.WriteLine("Adjon meg ket szamot!");
            int num_a = Int32.Parse(Console.ReadLine());
            int num_b = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"A szamtani kozepe {num_a} es {num_b} = {(num_a + num_b) / 2}");
        }
    }
}
