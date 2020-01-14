using System;
using System.Collections.Generic;
using System.Text;

namespace One_other
{
    class Driver
    {
        readonly string Name;
        public string CarName;
        public double Money { get; set; }

        public Driver(string name, double money)
        {
            this.Name = name;
            this.Money = money;
        }

        public override string ToString()
        {
            return $"{Name} has {Money}$ and he is driving the {CarName}";
        }
    }
}
