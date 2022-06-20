using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateBuilderConsole.Models.Invoer
{
    public class Constraint: InvoerBase
    {
        // attributes

        // constructor(s)
        public Constraint(): base()
        {
        }
        public Constraint(string[] headers, string[] values) : base(headers, values)
        {
        }

    }
}
