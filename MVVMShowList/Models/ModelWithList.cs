using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMShowList.Models
{
    public class ModelWithList
    {
        // attributes
        private List<String> items;

        // constructor
        public ModelWithList()
        {
            items = new List<String>();
            items.Append("Item1");
            items.Append("Item2");
            items.Append("Item3");
            items.Append("Item4");
            items.Append("Item5");
        }

        // properties
        public List<String> Items { get { return items; } }

    }
}
