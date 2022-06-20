using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateBuilderGUI.Models.Uitvoer
{
    public class UitvoerHyp
    {
        // attributen
        public List<VoiDef> voidefs = new List<VoiDef>();

        // methode
        public void wegschrijven(string filename) {

            StringBuilder sb = new StringBuilder();
        
            foreach(VoiDef voidef in voidefs)
            {
                sb.Append(voidef.Dump());
            }

            Console.Write(sb.ToString());
        }

    }
}
