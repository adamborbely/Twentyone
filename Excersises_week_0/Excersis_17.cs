using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_17
    {
        public Excersis_17()
        {
            Console.WriteLine("Adja meg a honap sorszamat:");
            var honap = Console.ReadLine();
            if (honap == "12" || honap == "1" || honap == "2")
            {
                Console.WriteLine("Tel");
            }
            else if (honap == "3" || honap == "4" || honap == "5")
            {
                Console.WriteLine("Tavasz");
            }
            else if (honap == "6" || honap == "7" || honap == "8")
            {
                Console.WriteLine("Nyar");
            }
            else if (honap == "9" || honap == "10" || honap == "11")
            {
                Console.WriteLine("Osz");
            }
            else
            {
                Console.WriteLine("Nem jol adta meg a kert adatot!");
            }
        }
    }
}
