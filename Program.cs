using System;
using System.Collections.Generic;

namespace Dealership{
    public class Program
    {
        public static void Main()
        {

            Car firstCar = new Car("Chrysler Lebaron", 4000, 200000);
            Car secondCar = new Car("Toyota RAV4", 4500, 175000);
            Car porsche = new Car("2014 Porsche 911", 114991, 7864);
            Car ford = new Car("2011 Ford F450", 55995, 14241);
            Car lexus = new Car("2013 Lexus RS", 44700, 20000);
            Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);

            lexus.SetPrice(2000);
            List<Car> cars = new List<Car>(){firstCar, secondCar, porsche, ford, lexus, mercedes};
            Console.WriteLine("Enter your maximum price.");
            string stringMaxPrice = Console.ReadLine();
            int maxPrice = int.Parse(stringMaxPrice);
            List<Car> carsMatchingSearch = new List<Car>(){};


            foreach (Car automobile in cars)
            {
                if (automobile.WorthBuying(maxPrice))
                {
                    carsMatchingSearch.Add(automobile);
                }
            }
            foreach (Car automobile in carsMatchingSearch)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine(automobile.GetMakeModel());
                Console.WriteLine(automobile.GetMiles() + " miles");
                Console.WriteLine("$" + automobile.GetPrice());
            }
        }
    }
}