using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TemplateBuilderConsole.Models.Invoer;
using TemplateBuilderConsole.Models.Uitvoer;

namespace TemplateBuilderConsole.Models
{
    public class Converter
    {
        // attributen

        public InvoerData invoerData { set; get; }
        public UitvoerHyp uitvoerData { set; get; }

        // constructor



        // methods
        public void convert()
        {
            UitvoerHyp uitvoerData = new UitvoerHyp();

            string lastName = "xxx";
            VoiDef voidef = null;

            foreach (Constraint constraint in invoerData.constraints)
            {
                string name = constraint.Attributes["name"];
                if (!name.Equals(lastName))
                {
                    voidef = new VoiDef();
                    voidef.Set("name", name);

                    uitvoerData.voidefs.Add(voidef);
                }

                CostFunction costFunction = new CostFunction();
                foreach (var item in constraint.Attributes)
                {
                    if (item.Value.Length > 0)
                    {
                        costFunction.Set(item.Key, item.Value);
                    }
                }

                voidef.costFunctions.Add(costFunction);
            }

            uitvoerData.wegschrijven("uitvoer.hyp");
        }

    }
}
