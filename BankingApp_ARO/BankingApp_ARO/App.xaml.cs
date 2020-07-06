using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BankingApp_ARO.Views;

namespace BankingApp_ARO
{
    public partial class App : Application
    {
        public const string appurl = "https://swapi.dev/api/";
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ContactsList());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
