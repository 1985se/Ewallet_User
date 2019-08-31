using EwalletApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace EwalletApp.ViewModels
{
  public  class LoginVM : INotifyPropertyChanged
    {
        
        public LoginVM()
        {
            OnClickSingInCommand = new Command(OnClickSingIn);

        }

        public Command OnClickSingInCommand { get; set; }

        private void OnClickSingIn(object obj)
        {
            Indicator = true;
            ActiveButton = false;
            toConfirmOTP();
            // ValidateEmail();
            Indicator = false;
            ActiveButton = true;



        }

        private async void toConfirmOTP()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.ConfirmOTP());
        }

        private async void ValidateEmail()
        {
            string Url = Constants.OpenApiEndpoint+ "/User/ValidateEmail";
            var uri = new Uri(Url);
            HttpClient _client = new HttpClient();
            EmailValidate userPass = new EmailValidate {Email = Email };
            var json = JsonConvert.SerializeObject(userPass);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = null;
                response = await _client.PostAsync(uri, content);
                if (response.IsSuccessStatusCode)
                {

                    var Otpdata = await response.Content.ReadAsStringAsync();
                    var OtpResult = JsonConvert.DeserializeObject<ResultModels<OtpRefMessage>>(Otpdata);
                    if (OtpResult.Message ==  ResultMessages.MessagesStatus.Success)
                    {
                        try
                        {
                            ErrorMessage = " ";
                            await Application.Current.MainPage.Navigation.PushAsync(new Views.ConfirmOTP());
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = "Service Error !!";
                        }

                    }
                    else
                    {
                        ErrorMessage = "Service Not Create OTP !!  ";

                    }

                }
                else
                {
                    ErrorMessage = "Can not Connect to Service";

                }
            }
            catch (Exception ex)
            {
                ErrorMessage = "Service Error";

            }




        }

        private string errorMessage;

        public string ErrorMessage
        {
            get { return errorMessage; }
            set { errorMessage = value; OnPropertyChanged("ErrorMessage"); }
        }


        private bool indicator;

        public bool Indicator
        {
            get { return indicator; }
            set { indicator = value; OnPropertyChanged("Indicator"); }
        }



        private string email;

        public string Email
        {
            get { return email; }
            set { email = value;
                VerdifyEmail(email);
                OnPropertyChanged("Email");
            }
        }

        private string statusEmailVerdify;

        public string StatusEmailVerdify
        {
            get { return statusEmailVerdify; }
            set { statusEmailVerdify = value; OnPropertyChanged("StatusEmailVerdify"); }
        }

        private bool activeButton;

        public bool ActiveButton
        {
            get { return activeButton; }
            set { activeButton = value; OnPropertyChanged("ActiveButton"); }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        private void VerdifyEmail(string email)
        {
            if (email.Length < 1)
            {
                StatusEmailVerdify = "Input Your Email";
                ActiveButton = false;
            }
            else
            {
                string strRegex =
                    @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(email))
                {
                    StatusEmailVerdify = " ";
                    ActiveButton = true;
                }
                else
                {
                    StatusEmailVerdify = "Email Invalid";
                    ActiveButton = false;
                }

            }



        }
    }
}
