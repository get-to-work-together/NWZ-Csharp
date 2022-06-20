using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPersoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoon persoon1 = new Persoon("Peter", "Lhee");

            persoon1.Woonplaats = "U";
            persoon1.vertel();

            Console.ReadKey();
        }
    }
}
