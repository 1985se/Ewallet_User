using EwalletApp.Models;
using EwalletApp.Models.ApiConnect;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace EwalletApp.ViewModels
{
    class TopupVM : INotifyPropertyChanged
    {

        public TopupVM()
        {

            TopupClickCommand = new Command(TopupClick);

        }


        private async void GetQrCode()
        {
            var userEail = await SecureStorage.GetAsync("Email");
            string Url = Constants.OpenApiEndpoint + "admin/QRString";
            // string Url = Constants.OpenApiEndpoint + "Admin/valus";
            var uri = new Uri(Url);
            HttpClient _client = new HttpClient();
            GetQR Data = new GetQR { Email = userEail, Amount = Convert.ToDecimal(Amount), AccType = 1, transectionType = 0 } ;
            var json = JsonConvert.SerializeObject(Data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                
               
              
                var response = await _client.PostAsync(uri, content);
                if (response.IsSuccessStatusCode)
                {
                    var Qrdata = await response.Content.ReadAsStringAsync();
                    var OtpResult = JsonConvert.DeserializeObject<ResultModels<QrResultModel>>(Qrdata);
                    if (OtpResult.Message == ResultMessages.MessagesStatus.Success)
                    {
                        try
                        {

                            QRCodeVM codeVM = new QRCodeVM
                            {
                                QRcode = OtpResult.Data[0].Qrcode,
                                RefQr = OtpResult.Data[0].QrRef,
                                Amount = Amount.ToString() + "THB",
                                 ExpDate = OtpResult.Data[0].Exp.ToString("dd MM yyyy hh mm")
                            };
                         
                            
                           
                           

                            await Application.Current.MainPage.Navigation.PushAsync(new Views.QRCode(codeVM));
                            //await Application.Current.MainPage.Navigation.PushAsync(new Views.Home());
                        }
                        catch (Exception ex)
                        {
                           // ErrorMessage = "Service Error !!";
                        }

                    }
                    else
                    {
                       // ErrorMessage = "Service Not Create OTP !!  ";

                    }

                }
                else
                {
                   // ErrorMessage = "Can not Connect to Service";

                }
            }
            catch (Exception ex)
            {
               // ErrorMessage = "Service Error";

            }




        }


        private async void TopupClick(object obj)
        {
            GetQrCode();
            
        }

        public Command TopupClickCommand { get; set; }

      

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private string qrcode;

        public string QRcode
        {
            get { return qrcode; }
            set { qrcode = value; OnPropertyChanged("QRcode"); }
        }


        private string refQr;

        public string RefQr
        {
            get { return refQr; }
            set { refQr = value; OnPropertyChanged("RefQr"); }
        }

        private string expDate;

        public string ExpDate
        {
            get { return expDate; }
            set { expDate = value; OnPropertyChanged("ExpDate"); }
        }


        private string amount;

        public string Amount
        {
            get { return amount; }
            set { amount = value; OnPropertyChanged("ExpDate"); }
        }

    }
}
