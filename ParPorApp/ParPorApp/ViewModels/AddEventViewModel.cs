using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Android.Media.Audiofx;
using Android.Util;
using ParPorApp.Helpers;
using ParPorApp.Models;
using ParPorApp.Services;
using Xamarin.Forms;

namespace ParPorApp.ViewModels
{
    class AddEventViewModel
    {
		ApiServices _apiServices = new ApiServices();
	    public string Description { get; set; }
	    public string StartDateTime { get; set; }
	    public string EndDateTime { get; set; }
		public ICommand AddEventCommand
	    {
		    get
		    {
				return new Command(async () =>
				{
					var events = new Events()
					{
						Description = Description,
						StartDateTime = StartDateTime,
						EndDateTime = EndDateTime
					};
					await _apiServices.PutEventAsync(events, Settings.AccessToken);
				});
		    }
	    }
    }
}
