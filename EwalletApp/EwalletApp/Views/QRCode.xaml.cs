﻿using EwalletApp.ViewModels;
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
    public partial class QRCode : ContentPage
    {
        

        public QRCodeVM _vM;


        public QRCode(QRCodeVM vM)
        {
            InitializeComponent();

            BindingContext = _vM = vM;

        }
      
    }
}