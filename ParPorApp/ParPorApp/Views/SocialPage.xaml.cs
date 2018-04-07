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
            
            Children.Add(new NewsfeedPage() { Title="Newsfeed", Icon = "ic_home.png" });
            Children.Add(new GroupPage() { Title="Social", Icon="ic_chat.png"});
            Children.Add(new EventsPage() { Title = "Events", Icon = "ic_event_black.png"});
            Children.Add(new UserProfilePage() { Title = "Profile", Icon = "ic_face.png"});

            //NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}