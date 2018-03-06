using System;
using ParPorApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParPorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    
    public partial class EventsPage : ContentPage
    {
	    EventsViewModel eventsViewModel;
		public EventsPage()
        {
            InitializeComponent();
	        
	        BindingContext = eventsViewModel = new EventsViewModel();
        }

	    protected override void OnAppearing()
	    {
		    base.OnAppearing();

		    eventsViewModel.GetEventsCommand.Execute(null);
	    }
		private async void LogoutMenuItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());

        }
    }
}