using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public static List<Car> CarsNow = new List<Car>();

        public Car()
        {
            this.Make = string.Empty;
            this.Model = string.Empty;
            this.Year = 0;
            this.Price = 0;
        }

        public Car(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;

        }

        
       

        public override string ToString ()
        {
            return (Make + "\t\t" + Model + "\t\t" + Year + "\t\t" + Price);
        }

        public static void ListCars (List<Car> cars)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine( i + 1 + ":  " + cars[i]);
                
            }
        }

        public static void RemoveFromStock(int choice)
        
        {
             CarsNow.RemoveAt(choice -1);
        }
           
        










    }
}
