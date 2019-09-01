using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EwalletApp.ViewModels
{
    public class RegisterVM : INotifyPropertyChanged
    {
        private ValidateData Validate;
        public RegisterVM()
        {
            Validate = new ValidateData();

        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        private bool sex;

        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        private void buttonStatus()
        {
            if(Validate.VerdifyNum(Tel) && 
                Validate.VerdifyName(Name) && 
                Validate.VerdifyName(LastName) && birthStatus)
            {
                ActiveButton = true;
            }
            else
            {
                ActiveButton = false;
            }
            
        }

        public bool birthStatus { get; set; }

        private string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; OnPropertyChanged("Tel"); }
        }

        private string birthday;

        public string Birthday
        {
            get { return birthday; }
            set { birthday = Validate.birthDateSet(value); OnPropertyChanged("Birthday"); }
        }

        


        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged("LastName"); }
        }

       

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }


        private bool indicator;

        public bool Indicator
        {
            get { return indicator; }
            set { indicator = value; OnPropertyChanged("Indicator"); }
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
    }
}
