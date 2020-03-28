﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Labtest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpQuestionPage : ContentPage
    {
        public SignUpQuestionPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            Application.Current.MainPage = new LoginPage();
            return true;
        }

        private void NextQuestion_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SignUpSummaryPage();
        }
    }
}