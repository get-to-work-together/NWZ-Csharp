using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Rekenmachine.ViewModels
{
    public class MainViewModel
    {

        private ICommand m_ButtonPressed;
        public ICommand ButtonPressed
        {
            get
            {
                return m_ButtonPressed;
            }
            set
            {
                m_ButtonPressed = value;
            }
        }

        public MainViewModel()
        {
            //            ButtonPressed = new RelayCommand(new Action<object>(ShowMessage));
        }

        public void ShowMessage(object obj)
        {
            MessageBox.Show(obj.ToString());
        }

    }
}
