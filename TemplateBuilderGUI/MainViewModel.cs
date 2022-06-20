using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TemplateBuilderGUI.Models;

namespace TemplateBuilderGUI
{
    public class MainViewModel
    {
        // attributes
        private TemplateBuilder templateBuilder;

        private List<string> doelgebieden;
        private List<string> dosisSchemas;
        private List<string> zijden;

        // properties
        public List<string> Doelgebieden { get => doelgebieden; set => doelgebieden = value; }
        public List<string> DosisSchemas { get => dosisSchemas; set => dosisSchemas = value; }
        public List<string> Zijden { get => zijden; set => zijden = value; }

        // constructor
        public MainViewModel()
        {
            templateBuilder = new TemplateBuilder();

            doelgebieden = templateBuilder.getDoelGebieden();
            dosisSchemas = templateBuilder.getDosisSchemas();
            zijden = templateBuilder.getZijden();
        }

    }
}
