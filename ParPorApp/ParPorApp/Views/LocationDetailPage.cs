using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParPorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class LocationDetailPage: ContentPage
    {
        public LocationDetailPage(Locations locations)
        {
            BindingContext = locations ?? throw new ArgumentNullException();
        }
    }
}
