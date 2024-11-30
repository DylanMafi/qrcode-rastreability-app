using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Labtest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultsPage : ContentPage
    {
        public ResultsPage()
        {
            list = new List<Item>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(new Item("Teste " + i.ToString()));
            }
            InitializeComponent();
            BindingContext = this;

        }

        public List<Item> list { get; set; }

        private void ResultsView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myListView = (ListView)sender;
            Item myItem = (Item)myListView.SelectedItem;
            Shell.Current.Navigation.PushAsync(new ResultPage(myItem.Title));
        }
    }

    public class Item
    {
        public Item(string title)
        {
            Title = title;
        }

        public string Title { get; set; }
    }
}