using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication
{
    public class Person
    {
        // attributes
        private string Name;
        private string Residence;

        // constructor
        public Person(string Name, string Residence)
        {
            this.Name = Name;
            this.Residence = Residence;
        }

        // methods
        public string TellMeAboutYourself()
        {
            return $"I am {Name} and I live in {Residence}";
        }

    }
}
