using System;
using Labtest.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Labtest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SplashPage();
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
