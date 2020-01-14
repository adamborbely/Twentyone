using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_8
    {
        public Excersis_8()
        {
            Console.WriteLine("Adjon meg ket szamot: ");
            int num_a = Int32.Parse(Console.ReadLine());
            int num_b = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"A lapatlo {(num_a * num_a) + (num_b * num_b)}");
            Console.WriteLine("Adjon meg meg 1 szamot: ");
            int num_c = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"A testatlo {Math.Sqrt((num_a * num_a) + (num_b * num_b) + (num_c * num_c))}");
            Console.WriteLine($"A felszin: {2 * (num_a * num_b + num_b * num_c + num_a * num_c)}");
            Console.WriteLine($"Terfogata: {num_a * num_b * num_c}");
        }
    }
}
