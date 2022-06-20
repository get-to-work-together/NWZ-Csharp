using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPersoon
{
    class Persoon
    {
        // attributen
        private string naam;
        private string woonplaats;

        // properties
        public string Naam { 
            get => naam; 
            private set => naam = value;
        }
        public string Woonplaats { 
            get => woonplaats;
            set {
                woonplaats = value != null && value.Length >= 2 ? value : woonplaats;
            } 
        }

        // constructor(s)
        public Persoon(string naam)
        {
            this.Naam = naam;
        }
        public Persoon(string naam, string woonplaats)
        {
            this.Naam = naam;
            this.Woonplaats = woonplaats;
        }

        // methodes

        public void vertel()
        {
            Console.WriteLine("Ik ben " + Naam + " en ik woon in " + Woonplaats);
        }

    }
}
