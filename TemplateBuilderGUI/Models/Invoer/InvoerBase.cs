using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateBuilderGUI.Models.Invoer
{
    public abstract class InvoerBase
    {
        // attributen
        private Dictionary<string, string> attributes;

        // properties
        public Dictionary<string, string> Attributes { get => attributes; set => attributes = value; }

        // constructor(s)
        public InvoerBase()
        {
            attributes = new Dictionary<string, string>();
        }
        public InvoerBase(string[] headers, string[] values): this()
        {
            build(headers, values);
        }

        // methods
        public void build(string[] headers, string[] values)
        {
            for (int i = 0; i < headers.Length; i++)
            {
                attributes[headers[i]] = values[i];
            }
        }
    }

}
