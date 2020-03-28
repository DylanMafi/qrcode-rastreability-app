using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Labtest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AppShell();
        }

        private void ForgotPassword_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ForgotPasswordPage();
        }

        private void SignUp_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SignUpQuestionPage();
        }
    }
}