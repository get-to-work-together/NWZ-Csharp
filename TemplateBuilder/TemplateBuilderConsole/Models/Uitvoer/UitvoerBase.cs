using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateBuilderConsole.Models.Uitvoer
{
    public abstract class UitvoerBase
    {

        // attributen
        protected Dictionary<string, string> attributes;
        protected string header = "!XXX";
        protected string footer = "!END";    

        // constructor
        public UitvoerBase()
        {
        }

        public UitvoerBase(string header): this()
        {
            this.header = header;
        }

        // methods
        public void Set(string key, string value)
        {
            attributes[key] = value;
        }

        public string Get(string key)
        {
            try
            {
                return attributes[key];
            }
            catch
            {
                return "NA";
            }
        }

        public string Dump()
        {
            return Dump(0);
        }
        public string Dump(int indentLevel)
        {
            const string INDENT = "\t";
            string prefix = string.Concat(Enumerable.Repeat(INDENT, indentLevel));
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(prefix + header);
            foreach (var attribute in attributes)
            {
                sb.AppendLine(prefix + INDENT + attribute.Key + "=" + attribute.Value);
            }
            sb.AppendLine(prefix + footer);
            return sb.ToString();
        }

    }
}
