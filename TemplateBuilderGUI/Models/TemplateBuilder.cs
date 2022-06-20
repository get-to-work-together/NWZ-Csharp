using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateBuilderGUI.Models
{
    public class TemplateBuilder
    {


        public List<string> getDoelGebieden()
        {
            List<string> lst = new List<string>();

            lst.Add("Mamma");
            lst.Add("Prostaat");
            lst.Add("Long");
            lst.Add("Schedel");
            lst.Add("Rectum");

            return lst;
        }

        public List<string> getDosisSchemas()
        {
            List<string> lst = new List<string>();

            lst.Add("25 x 2 Gy");
            lst.Add("35 x 2 Gy");
            lst.Add("45 x 2 Gy");
            lst.Add("25 x 3 Gy");

            return lst;
        }

        public List<string> getZijden()
        {
            List<string> lst = new List<string>();

            lst.Add("Links");
            lst.Add("Rechts");

            return lst;
        }

    }
}
