using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_2
    {
        public Excersis_2()
        {

            Console.WriteLine("Adj harom szamot es sorbarakom neked!");
            int num_a = Int32.Parse(Console.ReadLine());
            int num_b = Int32.Parse(Console.ReadLine());
            int num_c = Int32.Parse(Console.ReadLine());

            int[] intArray = new int[] { num_a, num_b, num_c };
            Array.Sort(intArray);
            Console.Write("A megadott szamok sorrendben: ");
            foreach (var item in intArray)
            {
                Console.Write(item + " ");
            }

        }
    }
}
