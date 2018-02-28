using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParPorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LatestPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }
        public LatestPage()
        {
            InitializeComponent();
            
        }
    }
}