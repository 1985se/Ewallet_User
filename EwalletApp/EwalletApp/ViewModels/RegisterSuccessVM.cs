using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EwalletApp.ViewModels
{
    public class RegisterSuccessVM : INotifyPropertyChanged
    {
        public RegisterSuccessVM()
        {

        }





        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
