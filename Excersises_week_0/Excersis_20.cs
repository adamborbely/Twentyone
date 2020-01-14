using System;
using System.Collections.Generic;
using System.Text;

namespace Excersises_1_20
{
    class Excersis_20
    {
        public Excersis_20()
        {
            Console.Write("Adjon meg egy osszeget:");
            var osszeg = Int32.Parse(Console.ReadLine());

            var ketszazas = osszeg / 200;
            var szazas = osszeg % 200 / 100;
            var otvenes = osszeg % 200 % 100 / 50;
            var huszas = osszeg % 200 % 100 % 50 / 20;
            var tizes = osszeg % 200 % 100 % 50 % 20 / 10;
            var otos = osszeg % 200 % 100 % 50 % 20 % 10 / 5;

            Console.WriteLine($"{osszeg} = {ketszazas} ketszazas, {szazas} szazas, " +
                $"{otvenes} otvenes, {huszas} huszas, {tizes} tizes es {otos} otos.");
        }
    }
}
