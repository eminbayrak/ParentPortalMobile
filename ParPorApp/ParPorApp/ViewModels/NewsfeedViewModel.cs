using ParPorApp.Models;
using Plugin.ExternalMaps;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ParPorApp.ViewModels
{
    internal class NewsfeedViewModel : ViewModelBase
    {
        public NewsfeedViewModel(Newsfeed newsfeed, Page page) : base(page)
        {
            Newsfeed = newsfeed;
        }

        public Newsfeed Newsfeed { get; set; }

        private Command _navigateCommand;

        public Command NavigateCommand
        {
            get
            {
                return _navigateCommand ?? (_navigateCommand = new Command(() =>
                           CrossExternalMaps.Current.NavigateTo(Newsfeed.Location, Newsfeed.Latitude,
                               Newsfeed.Longitude)));
            }
        }
    }
}
