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
    public partial class SignUpSummaryPage : ContentPage
    {
        public SignUpSummaryPage()
        {
            InitializeComponent();
        }

        private void Confirm_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AppShell();
        }

        protected override bool OnBackButtonPressed()
        {
            Application.Current.MainPage = new SignUpQuestionPage();
            return true;
        }
    }
}