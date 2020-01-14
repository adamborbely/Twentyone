using System;
using System.Collections.Generic;

namespace One_other
{
    class Program
    {
        static void Main(string[] args)
        {
            var zoltan = new Driver("Zoltan", 19254.43);
            var karcsi = new Driver("Karcsi", 132120);
            var bandi = new Driver("Bandi papa", 32121);
            var pisti = new Driver("Istike", 16000);
            var gabi = new Driver("Gabi", 17789.2);

            var alfa = new Car("Alfa RomeO", 7.5, 47, zoltan);
            var ferrari = new Car("Ferrari", 34, 120, karcsi);
            var opel = new Car("Opel", 8, 23, bandi);
            var wartburg = new Car("Wartburg", 14, 45, pisti);
            var polka = new Car("Kispolka", 4.8, 44, gabi);

            var bigCompany = new Company("Fonok szallitas",
                new List<Car>() { alfa, ferrari, opel, wartburg, polka });

            while (bigCompany.Cars.Count > 1)
            {
                var distance = bigCompany.TripLenght();
                var actualCar = bigCompany.ChoosingACar();
                Console.WriteLine(actualCar);
                if (actualCar.CheckFuel(distance))
                {
                    //Console.WriteLine($"{distance} km Iam ready for the trip {actualCar.Fuel}");
                    actualCar.NewTrip(distance);
                }
                else
                {
                    //Console.WriteLine($"{distance} I need more fuel {actualCar.Fuel}");
                    actualCar.Fueling(distance);
                    bigCompany.CheckCar(actualCar);
                }
            }


            Console.WriteLine($"{bigCompany.Cars[0].Driver} was the last car and the fuelstation: {FuelStation.FuelInStation}");
        }
    }
}
