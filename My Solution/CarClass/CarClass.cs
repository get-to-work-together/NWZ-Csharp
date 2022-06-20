using System;

namespace CarClass
{
    public class CarClass
    {
        static void Main(string[] args)
        {
            // polymorphy
            List<Car> wagenpark = new List<Car>();

            Car car1 = new Car("Renault", "Megane", 2016, "Metalic Bruin", 200000);
            wagenpark.Add(car1);

            Car car2 = new SportsCar("Porsch", "Fast", 2020, "Blue", 2000, 200);
            wagenpark.Add(car2);

            Car car3 = new Bus("VW", "2", 1980, "Blue", 300000, 8);
            wagenpark.Add(car3);

            foreach (Car car in wagenpark)
            {
                Console.WriteLine(car.info());
            }
        }
    }
}
