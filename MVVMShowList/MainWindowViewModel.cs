using MVVMShowList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMShowList
{
    public class MainWindowViewModel
    {
        private ModelWithList _ModelWithList;

        private List<String> _ListItems;
        public List<String> ListItems
        {
            get { return _ListItems; }
            set
            {
                _ListItems = value;
//                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            _ModelWithList = new ModelWithList();

            _ListItems = _ModelWithList.Items;
        }
    }
}
