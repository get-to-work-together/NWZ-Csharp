using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    public class Car
    {
        // properties

        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public string Color { get; private set; }
        public int Mileage { get; private set; }

        // constructor(s)

        public Car(string make, string model, int year, string color, int mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Mileage = mileage;
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Mileage = 0;
        }

        // methods

        public virtual string info()
        {
            return string.Format("Een {0} {1} {2} uit {3} met {4} km op de teller.", Color, Make, Model, Year, Mileage);
        }

        public void drive(int distance)
        {
            Mileage += distance;
        }

    }
}
