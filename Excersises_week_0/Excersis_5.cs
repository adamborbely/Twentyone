using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_5
    {
        public Excersis_5()
        {
            Console.WriteLine("Adjon meg ket szamot.");
            int num_a = Int32.Parse(Console.ReadLine());
            int num_b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{num_a} + {num_b} = {num_a + num_b}");
            Console.WriteLine($"{num_a} - {num_b} = {num_a - num_b}");
            Console.WriteLine($"{num_a} * {num_b} = {num_a * num_b}");
            Console.WriteLine($"{num_a} / {num_b} = {(double)num_a / num_b}");



        }
    }
}
