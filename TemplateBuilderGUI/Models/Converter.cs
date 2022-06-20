using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TemplateBuilderGUI.Models.Invoer;
using TemplateBuilderGUI.Models.Uitvoer;

namespace TemplateBuilderGUI.Models
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
            string lastName = "xxx";
            VoiDef voidef = null;

            foreach (Constraint constraint in invoerData.constraints)
            {
                string name = constraint.Attributes["name"];
                if (!name.Equals(lastName))
                {
                    voidef = new VoiDef();
                    voidef.Set("name", name);
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

            uitvoerData.voidefs.Add(voidef);

            Console.Write(voidef.Dump());

            uitvoerData.wegschrijven("uitvoer.hyp");
        }

    }
}
