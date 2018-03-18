using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ParPorApp.Models;
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

            //groupView.ItemsSource = new List<Event>
            //{
            //    new Event{ First = "Coach Ashley O'Toole", ImageUrl = "http://randomuser.me/api/portraits/med/women/85.jpg", PostDate = "09:12AM  03/12/2018", },
            //    new Event{ First = "Coach Mason", ImageUrl = "http://randomuser.me/api/portraits/med/women/2.jpg", PostDate = "7:53AM  05/18/2018"},
            //    new Event{ First = "Coach Stephen", ImageUrl = "http://randomuser.me/api/portraits/med/men/12.jpg", PostDate = "7:53AM  02/18/2018"},
            //    new Event{ First = "Coach Mark", ImageUrl = "http://randomuser.me/api/portraits/med/men/20.jpg", PostDate = "12:21PM  02/17/2018"},

            //};
        }

        protected override void OnAppearing()
	    {
		    base.OnAppearing();

		    eventsViewModel.GetEventsCommand.Execute(null);
	    }
		//private async void LogoutMenuItem_Clicked(object sender, EventArgs e)
  //      {
  //          await Navigation.PushAsync(new LoginPage());

  //      }

	    private async Task AddEvent_Clicked(object sender, EventArgs e)
	    {
			await Navigation.PushAsync(new AddEventPage());
		}
    }
}