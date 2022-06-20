using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateBuilderConsole.Models.Invoer
{
    public class InvoerData
    {
        // attributen
        public List<Constraint> constraints = new List<Constraint>();

        // Todo : ook voor Beams, General, DosisSchemas ...


        // constructor



        // methods
        public void readConstraints(string constraintFilename)
        {
            char sep = ';';
            // Eerste regel bevat headers. Wordt hier verder niet gebruikt.
            string[] headers = File.ReadLines(constraintFilename).First().Split(sep);

            foreach (string line in File.ReadLines(constraintFilename).Skip(1))
            {
                string[] values = line.Split(sep);

                constraints.Add(new Constraint(headers, values));
            }

        }
    }
}
