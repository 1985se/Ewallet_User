using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace EwalletApp.ViewModels
{
    public class QRCodeVM : INotifyPropertyChanged
    {

        public QRCodeVM()
        {
            BackToHomeCilckCommand = new Command(BackToHomeCilck);
        }

        private void BackToHomeCilck(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Views.Home());
        }
           
        public Command BackToHomeCilckCommand { get; set; }
        private string qrcode;

        public string QRcode
        {
            get { return qrcode; }
            set { qrcode = value;  }
        }


        private string refQr;

        public string RefQr
        {
            get { return refQr; }
            set { refQr = value; }
        }

        private string expDate;

        public string ExpDate
        {
            get { return expDate; }
            set { expDate = value;  }
        }


        private string amount;

        public string Amount
        {
            get { return amount; }
            set { amount = value;  }
        }





        public event PropertyChangedEventHandler PropertyChanged;
       
    }
}
