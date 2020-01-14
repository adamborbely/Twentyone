using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_16
    {
        public Excersis_16()
        {
            bool equals = false;

            while (!equals)
            {
                Console.Write("Adja meg a jelszot: ");
                string pw = "password123";
                var logIn = Console.ReadLine();

                if (pw == logIn)
                {
                    Console.WriteLine("A jelszo egyezik!");
                    equals = true;
                }
                else
                {
                    Console.WriteLine("Hibas jelszo!");
                }
            }
        }
    }
}
