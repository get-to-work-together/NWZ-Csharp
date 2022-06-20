using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    public class SportsCar : Car
    {
        // Properties
        public int MaxSnelheid { get; set; }


        // Constructor(s)
        public SportsCar(string make, string model, int year, string color, int mileage, int maxSnelheid)
            : base(make, model, year, color, mileage)
        {
            MaxSnelheid = maxSnelheid;
        }

        // overriden methodes
        public override string info()
        {
            return string.Format("Een sportscar {0} {1} {2} uit {3} met {4} km op de teller en een topsnelheid van {5} km/uur.", Color, Make, Model, Year, Mileage, MaxSnelheid);
        }


    }
}
