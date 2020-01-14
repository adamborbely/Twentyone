using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_1
    {
        public float Terulet(int sugar)
        {
            return (float)sugar * (float)sugar * (float)Math.PI;
        }
        public float Felszin(int sugar)
        {
            return 4 * (float)Math.PI * sugar * sugar;
        }
        public double Terfogat(int sugar)
        {
            return (4 * Math.Pow((double)sugar, 3) * Math.PI) / 3;
        }
    }
}
