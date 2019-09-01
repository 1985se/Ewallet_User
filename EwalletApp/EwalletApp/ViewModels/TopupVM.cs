using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EwalletApp.ViewModels
{
    class TopupVM : INotifyPropertyChanged
    {

        public TopupVM()
        {


        }
        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
