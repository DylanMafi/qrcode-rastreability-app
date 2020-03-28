using Labtest.Views;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Labtest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }

        Dictionary<string, Type> routes = new Dictionary<string, Type>();

        public ICommand NavigateCommand => new Command(Navigate);
        public ICommand FaqCommand => new Command(async () => await PushPage(new FaqPage()));

        private async Task PushPage(Page page)
        {
            await Shell.Current.Navigation.PushAsync(page);
            Shell.Current.FlyoutIsPresented = false;
        }

        private async void Navigate(object route)
        {
            ShellNavigationState state = Shell.Current.CurrentState;
            await Shell.Current.GoToAsync($"{state.Location}/{route.ToString()}");
            Shell.Current.FlyoutIsPresented = false;
        }

        void RegisterRoutes()
        {
            routes.Add("sendexam", typeof(SendExamPage));
            routes.Add("results", typeof(ResultsPage));
            routes.Add("useradmin", typeof(UserAdminPage));
            routes.Add("faq", typeof(FaqPage));

            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
    }
}