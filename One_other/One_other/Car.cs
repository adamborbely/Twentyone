using System;
using System.Collections.Generic;
using System.Text;

namespace One_other
{
    class Car
    {
        public string Name { get; set; }
        readonly double Consumption;
        public double Fuel;
        public bool Working = true;
        public Driver Driver;

        public Car(string name, double consumption, double fuel, Driver driver)
        {
            this.Name = name;
            this.Consumption = consumption;
            this.Fuel = fuel;
            this.Driver = driver;
            driver.CarName = name;

        }

        public bool CheckFuel(double distance)
        {
            if ((Fuel / Consumption) * 100 > distance)
            {
                return true;
            }
            return false;
        }

        public void NewTrip(double distance)
        {
            this.Fuel -= Consumption * distance / 100;
        }

        public void Fueling(double distance)
        {
            if (Driver.Money > (distance / 100 * Consumption - Fuel) * FuelStation.Price && FuelStation.FuelInStation > distance / 100 * Consumption - Fuel)
            {
                Driver.Money -= (distance / 100 * Consumption - Fuel) * FuelStation.Price;
                FuelStation.Cassa += (distance / 100 * Consumption - Fuel) * FuelStation.Price;
                FuelStation.FuelInStation -= distance / 100 * Consumption - Fuel;
                this.Fuel += distance / 100 * Consumption - Fuel;
                Console.WriteLine($"Was just tanking {Driver.Money}$ left {Fuel}");
                NewTrip(distance);
            }
            else
            {
                this.Working = false;

            }
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
