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
            
            Children.Add(new LatestPage() { Title="Newsfeed", Icon = "ic_grade_18.png"});
            Children.Add(new TablePage() { Title = "Places", Icon="fa-archive"});
            Children.Add(new GamesPage() { Title = "Games", Icon = "ic_trophy.png"});
            
        }
    }
}