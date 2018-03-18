using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ParPorApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParPorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public class Locations
    {
        public int Id { get; set; }
        public string PlaceName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string UriImage { get; set; }

    }
    public partial class LocationsPage : ContentPage
    {
        
        public LocationsPage()
        {
            InitializeComponent();
            LocationsListView.ItemsSource = new List<Locations>
            {
                new Locations {PlaceName = "Milford Junior High School", Address = "5735 Wolfpen Pleasant Hill Rd, Milford, OH 45150", PhoneNumber = "(513)-831-1900", Website = "https://www.milfordschools.org/", UriImage = "milford.png"}
            };
            base.OnAppearing();
        }

        async void Locations_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var contact = e.SelectedItem as Locations;
            await Navigation.PushAsync(new LocationDetailPage(locations));
            LocationsListView.SelectedItem = null;
        }
    }
}
