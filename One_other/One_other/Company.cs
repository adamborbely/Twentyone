using System;
using System.Collections.Generic;
using System.Text;

namespace One_other
{
    class Company
    {
        public List<Car> Cars;
        string Name;

        public Company(string name, List<Car> cars)
        {
            this.Name = name;
            this.Cars = cars;
        }

        public Car ChoosingACar()
        {
            Random random = new Random();
            return Cars[random.Next(0, Cars.Count)];
        }

        public int TripLenght()
        {
            Random random = new Random();
            return random.Next(100, 1111);
        }
        public void CheckCar(Car car)
        {
            if (!car.Working)
            {
                Console.WriteLine(car.Working + "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" + car);
                Cars.Remove(car);
            }
        }
    }
}
