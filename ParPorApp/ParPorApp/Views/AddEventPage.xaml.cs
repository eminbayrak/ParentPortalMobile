using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParPorApp.ViewModels;
using Plugin.LocalNotifications;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.DateTime;

namespace ParPorApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddEventPage : ContentPage
	{
		public AddEventPage ()
		{
			InitializeComponent ();
		    //BindingContext = new GroupsViewModel();
        }

	    private void DatePicker_StartDateSelected(object sender, DateChangedEventArgs e)
	    {
	        StartDate.Text = e.NewDate.Month.ToString() + "/" + e.NewDate.Day.ToString() + "/" + e.NewDate.Year.ToString() + " " + StartTime.Time.ToString();
        }

	    private void DatePicker_FinishDateSelected(object sender, DateChangedEventArgs e)
	    {
	        string dateTime = e.NewDate.Month.ToString() + "/" + e.NewDate.Day.ToString() + "/" + e.NewDate.Year.ToString() + " " + EndTime.Time.ToString();
	        FinishDate.Text = dateTime;


        }

        private async Task ReturnEventPage_Clicked(object sender, EventArgs e)
		{
            await Task.Delay(3000);
		    await Navigation.PushAsync(new EventsPage());
		    CrossLocalNotifications.Current.Show("New Event!", "A new content has posted.", 1, UtcNow.AddSeconds(8));
		}

	}
}