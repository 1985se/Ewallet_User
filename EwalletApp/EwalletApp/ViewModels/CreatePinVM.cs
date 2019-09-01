using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace EwalletApp.ViewModels
{
    public class CreatePinVM : INotifyPropertyChanged
    {


        public CreatePinVM()
        {
            OnKeypadClickCommand = new Command(OnKeypadClick);
        }



        public Command OnKeypadClickCommand { get; set; }
        private void OnKeypadClick(object obj)
        {

            var st = obj.ToString();
            if (PreatePass == null)
            {
                PreatePass = "";
            }
            if (st == "Del" && PreatePass.Length > 0)
            {
                PreatePass = PreatePass.Remove(PreatePass.Length - 1);
                passRunning(PreatePass);
            }
            else if (st != "Del")
            {
                PreatePass += st;
                passRunning(PreatePass);
            }
        }


        private string createPass;

        public string PreatePass
        {
            get { return createPass; }
            set { createPass = value; OnPropertyChanged("PreatePass"); }
        }
        private void passRunning(string pass)
        {
            int passCount = pass.Length;
            switch (passCount)
            {
                case 1:
                    Bg0 = Color.Gray;
                    Bg1 = Bg2 = Bg3 = Bg4 = Bg5 = Color.White;
                    break;
                case 2:
                    Bg0 = Bg1 = Color.Gray;
                    Bg2 = Bg3 = Bg4 = Bg5 = Color.White;
                    break;
                case 3:
                    Bg0 = Bg1 = Bg2 = Color.Gray;
                    Bg3 = Bg4 = Bg5 = Color.White;
                    break;
                case 4:
                    Bg0 = Bg1 = Bg2 = Bg3 = Color.Gray;
                    Bg4 = Bg5 = Color.White;
                    break;
                case 5:
                    Bg0 = Bg1 = Bg2 = Bg3 = Bg4 = Color.Gray;
                    Bg5 = Color.White;
                    break;
                case 6: Bg0 = Bg1 = Bg2 = Bg3 = Bg4 = Bg5 = Color.Gray; break;
                default: Bg0 = Bg1 = Bg2 = Bg3 = Bg4 = Bg5 = Color.White; break;
            }

        }
        private Color bg0;

        public Color Bg0
        {
            get { return bg0; }
            set { bg0 = value; OnPropertyChanged("Bg0"); }
        }

        private Color bg1;

        public Color Bg1
        {
            get { return bg1; }
            set { bg1 = value; OnPropertyChanged("Bg1"); }
        }

        private Color bg2;

        public Color Bg2
        {
            get { return bg2; }
            set { bg2 = value; OnPropertyChanged("Bg2"); }
        }
        private Color bg3;

        public Color Bg3
        {
            get { return bg3; }
            set { bg3 = value; OnPropertyChanged("Bg3"); }
        }
        private Color bg4;

        public Color Bg4
        {
            get { return bg4; }
            set { bg4 = value; OnPropertyChanged("Bg4"); }
        }

        private Color bg5;

        public Color Bg5
        {
            get { return bg5; }
            set { bg5 = value; OnPropertyChanged("Bg5"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
