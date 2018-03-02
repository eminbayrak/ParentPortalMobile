using System;
using Plugin.ExternalMaps;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParPorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactDetailPage : ContentPage
    {
        public ContactDetailPage(Models.Newsfeed contact)
        {
            InitializeComponent();
            BindingContext = contact ?? throw new ArgumentNullException();

        }

	    private void TakeMeThere_Clicked(object sender, EventArgs e)
	    {
			CrossExternalMaps.Current.NavigateTo("Milford", "5735 Wolfpen Pleasant Hill Rd", "Milford", "OH", "45150", "USA", "USA");
		}
    }
}