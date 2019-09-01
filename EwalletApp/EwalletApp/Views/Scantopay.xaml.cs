using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EwalletApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Scantopay : ContentPage
    {
        public Scantopay()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            //var scanner = new ZXing.Mobile.MobileBarcodeScanner();

            //var result = await scanner.Scan();

            //if (result != null)
            //{
            //    DisplayAlert("Data", result.Text, "ok");
            //}

        }
    }
}