using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_9
    {
        public Excersis_9()
        {
            Console.WriteLine("Adja meg a teglatest oldalait:");
            int num_a = Int32.Parse(Console.ReadLine());
            int num_b = Int32.Parse(Console.ReadLine());
            int num_c = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Az oldalelek osszege: {4 * (num_a + num_b + num_c)}");
            Console.WriteLine($"A felszin: {2 * (num_a * num_b + num_b * num_c + num_a * num_c)}");
            Console.WriteLine($"Terfogata: {num_a * num_b * num_c}");
        }
    }
}
