using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class UsedCars : Car
    {
        public double Mileage { get; set; }

        public UsedCars()
        {
            this.Mileage = 0;
        }

        public UsedCars(string Make, string Model, int Year, decimal Price, double Mileage) : base(Make, Model, Year, Price)
        {
            this.Mileage = Mileage;
        }
        public override string ToString()
        {
            return (Make + "\t\t" + Model + "\t\t" + Year + "\t\t" + Price + "\t USED: " + Mileage + "\tmiles");
        }
    }
}
