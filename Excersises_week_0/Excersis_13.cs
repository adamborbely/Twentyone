using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_13
    {
        public Excersis_13()
        {
            Console.WriteLine("Adja meg a honap nevet(nagy kezdobetu, ekezet nelkul):");
            var honap = Console.ReadLine();
            if (honap == "December" || honap == "Januar" || honap == "Februar")
            {
                Console.WriteLine("Tel");
            }
            else if (honap == "Marcius" || honap == "Aprilis" || honap == "Majus")
            {
                Console.WriteLine("Tavasz");
            }
            else if (honap == "Junius" || honap == "Julius" || honap == "Augusztus")
            {
                Console.WriteLine("Nyar");
            }
            else if (honap == "Szeptember" || honap == "November" || honap == "Oktober")
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
