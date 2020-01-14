using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_14
    {
        public Excersis_14()
        {
            Console.WriteLine("Add meg az eves bevetelt!");
            int bev = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az eves kiadast!");
            int kiadas = Int32.Parse(Console.ReadLine());

            if (bev - kiadas > 0)
            {
                Console.WriteLine($"Nyereseges ev, a nyereseg: {bev - kiadas}");
            }
            else if (bev - kiadas == 0)
            {
                Console.WriteLine("Nullas ev");
            }
            else
            {
                Console.WriteLine($"Buko: {bev - kiadas}");
            }

        }
    }
}
