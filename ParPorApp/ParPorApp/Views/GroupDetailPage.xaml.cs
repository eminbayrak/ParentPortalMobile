using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ParPorApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ParPorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public class GroupDetail
    {
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string Twitter { get; set; }
        public string Email { get; set; }
 
    }
    public partial class GroupDetailPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public GroupDetailPage()
        {
            InitializeComponent();
            Title = "Group Detail";



            groupdetailView.ItemsSource = new List<GroupDetail>
            {
                new GroupDetail
                {
                    Name ="Girls Soccer",
                    Description = "Girls Soccer Program",
                    Picture = "princeton.png",
                    Phone = "555-555-5555",
                    Address = "100 Viking Way, Cincinnati, OH 45246"
                }
            };

            base.OnAppearing();
        }

        private void WebsiteButton_OnClicked(object sender, EventArgs e)
        {
            
            Device.OpenUri(new Uri("https://www.princetonschools.net/"));

        }
    }
}