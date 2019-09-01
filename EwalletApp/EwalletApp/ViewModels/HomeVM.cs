using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace EwalletApp.ViewModels
{
    public class HomeVM  : INotifyPropertyChanged
    {

        public HomeVM()
        {
            TopupClickCommand = new Command(TopupClick);
           
        }

      
        private async void TopupClick()
        {

            await Application.Current.MainPage.Navigation.PushAsync(new Views.QRCode());
        }

    
        public Command TopupClickCommand { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
