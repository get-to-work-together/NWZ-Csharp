using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TemplateBuilderGUI.Models.Uitvoer
{
    public class VoiDef : UitvoerBase
    {
        // attributen
        public List<CostFunction> costFunctions = new List<CostFunction>();

        // constructor
        public VoiDef() : base()
        {
            header = "!VOIREF";

            attributes = new Dictionary<string, string>
            {
                ["name"] = "...",
                ["storenodose"] = "0",
                ["conformalavoidance"] = "0",
            };
        }

        // methods
        public string Dump(int indentLevel)
        {
            string s = base.Dump(indentLevel);
            int i = Regex.Matches(s, @"\t*" + footer + @"[\r\n]+\z")[0].Index;
            string s1 = s.Substring(0, i);
            string s2 = s.Substring(i);

            StringBuilder sb = new StringBuilder(s1);

            foreach (CostFunction costFunction in costFunctions)
            {
                sb.Append(costFunction.Dump(indentLevel + 1));
            }

            sb.Append(s2);

            return sb.ToString();
        }

    }
}
