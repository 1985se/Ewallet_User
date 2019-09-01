using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EwalletApp.ViewModels
{
    public class HomeVM  : INotifyPropertyChanged
    {





        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
