using System.ComponentModel;

namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Car a = new Car("Fordddds", "FMannn50", 1999, (decimal)18889.99);
            Car b = new Car("Chadroley", "Qurooooze", 2008, (decimal)14447.77  );
            Car c = new Car("Djgiiip", "Grand Algonquin", 2023, (decimal) 98765.43);
            UsedCars d = new UsedCars("Explodemobl", "Hurricado", 1967, (decimal)2333.34, 200002);
            UsedCars e = new UsedCars("Beyondai", "CheapBox", 2016, (decimal)5901.88, 175000);
            UsedCars f = new UsedCars("Brit Motors", "Essential Mix", 2002, (decimal)7779.99, 84000);

            Car.CarsNow.Add(a);
            Car.CarsNow.Add(b);
            Car.CarsNow.Add(c);
            Car.CarsNow.Add(d);
            Car.CarsNow.Add(e);
            Car.CarsNow.Add(f);

            Console.WriteLine("Hello, Welcome to Car Place!!");
            Console.WriteLine("(the place for cars)");
            Console.WriteLine("Please select a car to buy or test drive by index");
            Console.WriteLine();
            Car.ListCars(Car.CarsNow);
            Console.WriteLine();
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Car.RemoveFromStock(choice);
            Console.WriteLine("Here is the new stock");
            Car.ListCars(Car.CarsNow);

            Console.WriteLine();
            Console.WriteLine("We hope our old car is your new car!");
            Console.WriteLine("Have a wonderful day");







        }

    }
}