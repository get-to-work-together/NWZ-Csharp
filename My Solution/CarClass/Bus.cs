using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    public class Bus : Car
    {
        // properties
        public int MaxNumberOfPassengers { get; set; }

        // constructor
        public Bus(string make, string model, int year, string color, int mileage, int maxNumberOfPassengers)
            : base(make, model, year, color, mileage)
        {
            this.MaxNumberOfPassengers = maxNumberOfPassengers;
        }

        // overriden methodes
        public override string info()
        {
            return string.Format("Een {0} {1} {2} bus uit {3} met {4} km op de teller voor maximaal {5} passangers.", Color, Make, Model, Year, Mileage, MaxNumberOfPassengers);
        }
    }
}
