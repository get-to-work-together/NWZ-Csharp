using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TemplateBuilderConsole.Models;
using TemplateBuilderConsole.Models.Invoer;
using TemplateBuilderConsole.Models.Uitvoer;

namespace TemplateBuilderConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // een constraint
            //var constraint = new Constraint("01.PTV sd", null, 61.37, 0, 1, "qp");

            // meedere constraints
            //InvoerData data = new InvoerData();
            //data.constraints.Add(new Constraint("01.PTV sd", null, 61.37, 0, 1, "qp"));
            //data.constraints.Add(new Constraint("01.PTV sd", null, 0.25,  2, 1, "o_q"));

            // uit een bestand
            //string filename = @"Y:\!! Circum\Noordwest Ziekenhuis Alkmaar\C#\Sandbox\TemplateBuilderConsole\VOIlist.csv";
            //InvoerData data = new InvoerData();
            //data.readConstraints(filename);

            //convert
            string filename = @"Y:\_Circum\Noordwest Ziekenhuis Alkmaar\C#\Sandbox\TemplateBuilder\TemplateBuilderConsole\VOIlist.csv";
            InvoerData invoerData = new InvoerData();
            invoerData.readConstraints(filename);

            Converter converter = new Converter();
            converter.invoerData = invoerData;
            converter.convert();
            UitvoerHyp uitvoerHyp = converter.uitvoerData;

            //var costFunction = new CostFunction();
            //costFunction.Set("type", "HALALUJA!!!");
            //costFunction.Set("extra", "HALALUJA!!!");

            //string uitvoer = costFunction.Dump();
            //Console.Write(uitvoer);

            Console.ReadLine();
        }
    }
}
