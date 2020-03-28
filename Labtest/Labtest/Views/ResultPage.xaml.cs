
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Labtest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage : ContentPage
    {
        public ResultPage(string exam)
        {
            Exam =  "Bem vindo a tela do resultado do " + exam;
            InitializeComponent();
            BindingContext = this;
        }

        public string Exam { get; set; }
    }
}