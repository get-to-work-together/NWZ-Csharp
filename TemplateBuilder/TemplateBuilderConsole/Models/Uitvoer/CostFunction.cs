using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateBuilderConsole.Models.Uitvoer
{
    public class CostFunction: UitvoerBase
    {
        // constructor
        public CostFunction(): base()
        {
            header = "!COSTFUNCTION";

            attributes = new Dictionary<string, string>
            {
                ["type"] = "...",
                ["usedensity"] = "0",
                ["effectweighting"] = "0",
                ["totalvolume"] = "0",
                ["sanesurfacedose"] = "1",
                ["multicriterial"] = "0",
                ["relaxfirst"] = "0",
                ["usebiasdose"] = "1",
                ["alpha"] = "0",
                ["beta_alpha"] = "0",
                ["celldensity"] = "0",
                ["refdose"] = "0",
                ["functreserve"] = "50",
                ["refvolume"] = "0.9900000000000001",
                ["exponent"] = "1",
                ["thresholddose"] = "1",
                ["isoconstraint"] = "61.370000000000005",
                ["isoeffect"] = "61.960066394609427",
                ["relativeimpact"] = "0",
                ["status"] = "1",
                ["manual"] = "0",
                ["weight"] = "1",
                ["groupmargins"] = "0",
                ["applyshrinkmargintooars"] = "1",
                ["oarsmargin"] = "0"
            };

        }

    }

}
