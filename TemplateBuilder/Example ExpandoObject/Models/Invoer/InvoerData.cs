using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_ExpandoObject.Models
{
    internal class InvoerData
    {

        // attributen
        public List<Constraint> constraints = new List<Constraint>();

        // Todo : ook voor Beams, General, DosisSchemas ...


        // constructor



        // methods
        public void readConstraints(string constraintFilename)
        {
            // Eerste regel bevat headers.
            string headerline = File.ReadLines(constraintFilename).First();

            foreach (string line in File.ReadLines(constraintFilename).Skip(1))
            {
                this.constraints.Add(Constraint.BuildConstraint(headerline, line));
            }

        }

    }
}
