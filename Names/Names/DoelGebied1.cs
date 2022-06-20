using System.Collections.ObjectModel;

namespace Names
{
    public class DoelGebied1
    {
        public string Name { get; set; }

        public ObservableCollection<DoelGebied2> Test2Items { get; set; }
        public override string ToString()
        {
            return Name;
        }

    }





}
