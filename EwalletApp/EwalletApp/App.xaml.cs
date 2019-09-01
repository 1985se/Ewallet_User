using EwalletApp.ViewModels;
using EwalletApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EwalletApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            LoginVM vM = new LoginVM();
            //  MainPage = new NavigationPage(new Login(vM));
            MainPage = new NavigationPage(new Views.Home());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
