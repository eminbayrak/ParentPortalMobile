using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BottomBar.XamarinForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParPorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SocialPage : BottomBarPage
    {
        public SocialPage()
        {
            InitializeComponent();
            
            Children.Add(new NewsfeedPage() { Title="Newsfeed", Icon = "ic_grade_18.png" });
            Children.Add(new GamesPage() { Title = "Games", Icon="ic_games.png"});
            Children.Add(new PlacesPage() { Title = "Places", Icon = "ic_place.png"});
            
        }
    }
}