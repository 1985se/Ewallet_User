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
            ScantopayClickCommand = new Command(ScantopayClick);
           
        }

        private async void ScantopayClick(object obj)
        {
            //var scanner = new ZXing.Mobile.MobileBarcodeScanner();

            //var result = await scanner.Scan();

            //if (result != null)
            //{
            //   await Application.Current.MainPage.DisplayAlert("Data", result.Text, "ok");
            //}
            //await Application.Current.MainPage.Navigation.PushAsync(new Views.Scantopay());

        }

        private async void ScantoTopupClick()
        {
            var scanner = new ZXing.Mobile.MobileBarcodeScanner();

            var result = await scanner.Scan();

            if (result != null)
            {
                await Application.Current.MainPage.DisplayAlert("Data", result.Text, "ok");
            }

        }

        public Command ScantopayClickCommand { get; set; }
        public Command ScantoTopupClickCommand { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
