using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example_ExpandoObject.Models;

namespace Example_ExpandoObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // convert
            string filename = @"Y:\!! Circum\Noordwest Ziekenhuis Alkmaar\C#\Sandbox\TemplateBuilderConsole\VOIlist.csv";
            InvoerData invoerData = new InvoerData();
            invoerData.readConstraints(filename);

/*            Converter converter = new Converter();
            converter.invoerData = invoerData;
            converter.convert();
            UitvoerHyp uitvoerHyp = converter.uitvoerData;
*/


        }
    }
}
