using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Javax.Security.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParPorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public class Places
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string SchoolWebsite { get; set; }
        public string SchoolImage { get; set; }
        public string Social { get; set; }
    }
	public partial class PlacesPage : ContentPage
	{
	    //private ObservableCollection<string> Schools { get; set; }
        

        public PlacesPage ()
		{
            
			InitializeComponent ();
		    placesView.ItemsSource = new List<Places>
		    {
		        new Places{ SchoolName = "Milford High School", SchoolImage = "milford.png",Social="https://twitter.com/milford_schools", SchoolWebsite = "https://www.milfordschools.org/contact-us/milford-high-school-2/"},
		        new Places{ SchoolName = "Princeton High School", SchoolImage = "princeton.png",Social="https://twitter.com/milford_schools", SchoolWebsite = "https://www.milfordschools.org/contact-us/milford-high-school-2/"},
		        new Places{ SchoolName = "Wyoming High School", SchoolImage = "https://static.hudl.com/users/temp/7904_4f62ac1ed74147fea5625b458801bda0.jpg",Social="https://twitter.com/milford_schools", SchoolWebsite = "https://www.wyomingcityschools.org/"},
		        new Places{ SchoolName = "Oak Hills High School", SchoolImage = "https://pbs.twimg.com/profile_images/889874480155303936/WeSGBPw8_400x400.jpg",Social="https://twitter.com/milford_schools", SchoolWebsite = "https://www.milfordschools.org/contact-us/milford-high-school-2/"},

            };
        }
	}
}