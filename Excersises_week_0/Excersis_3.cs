using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_3
    {
        public Excersis_3()
        {
            Console.WriteLine("Adjon meg harom szamot es elarulom lehet e belole haromszoget szerkeszteni");
            int num_a = Int32.Parse(Console.ReadLine());
            int num_b = Int32.Parse(Console.ReadLine());
            int num_c = Int32.Parse(Console.ReadLine());

            if (Szerkeztheto(num_a, num_b, num_c))
            {
                Console.WriteLine("A haromszog szerkeztheto!");
            }
            else
            {
                Console.WriteLine("Nem szerkeztheto a haromszog!");
            }

        }
        public bool Szerkeztheto(int num_a, int num_b, int num_c)
        {
            if (num_a + num_b > num_c)
            {
                if (num_a + num_c > num_b)
                {
                    if (num_b + num_c > num_a)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
