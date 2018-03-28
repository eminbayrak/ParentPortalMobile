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

    public class GroupsDetail
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public partial class GroupDetailPage : ContentPage
    {
        public ObservableCollection<string> GroupsItems { get; set; }

        public GroupDetailPage()
        {
            InitializeComponent();
            
            groupsDetailView.ItemsSource = new List<GroupsDetail>
            {
                new GroupsDetail
                {
                    Name = "Ashley O'Toole",
                    ImageUrl = "http://randomuser.me/api/portraits/med/women/19.jpg",
                    Description = "Team Coach",
                    Phone = "555-555-5555",
                    Email = "aotoole@mail.com"
                },
                new GroupsDetail
                {
                    Name = "Andrue Stephen",
                    ImageUrl = "https://ui-avatars.com/api/?background=a457&color=ffff&name=A+S",
                    Description = "Carlie Stephen's parent",
                    Phone = "555-555-5555",
                    Email = "astephen@mail.com"
                },
                new GroupsDetail
                {
                    Name = "Alexis Alper",
                    ImageUrl = "https://ui-avatars.com/api/?background=2267&color=ffff&name=A+A",
                    Description = "Addison Alper's parent",
                    Phone = "555-555-5555",
                    Email = "aalper@mail.com"
                },
                new GroupsDetail
                {
                    Name = "Rhonda Shay",
                    ImageUrl = "https://ui-avatars.com/api/?background=6737&color=ffff&name=R+S",
                    Description = "Caitlyn Shay's parent",
                    Phone = "555-555-5555",
                    Email = "rshay@mail.com"
                },
                new GroupsDetail
                {
                    Name = "Catherine Mason",
                    ImageUrl = "https://ui-avatars.com/api/?background=c334&color=ffff&name=C+M",
                    Description = "Allison's parent",
                    Phone = "555-555-5555",
                    Email = "cmason@mail.com"
                },
                new GroupsDetail
                {
                    Name = "Elise Wene",
                    ImageUrl = "https://ui-avatars.com/api/?background=e461&color=ffff&name=E+W",
                    Description = "Grace Wene's parent",
                    Phone = "555-555-5555",
                    Email = "ewene@mail.com"
                },
                new GroupsDetail
                {
                    Name = "Hannah Kemen",
                    ImageUrl = "https://ui-avatars.com/api/?background=4654&color=ffff&name=H+K",
                    Description = "Haley Kemen's parent",
                    Phone = "555-555-5555",
                    Email = "hkemen@mail.com"
                },
                new GroupsDetail
                {
                    Name = "Kacey Bail",
                    ImageUrl = "https://ui-avatars.com/api/?background=f2d1&color=ffff&name=K+B",
                    Description = "Charlie Steven's parent",
                    Phone = "555-555-5555",
                    Email = "kbail@mail.com"
                }
            };
            base.OnAppearing();
        }

        async void GroupsMemberView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var memberDetail = e.SelectedItem as GroupsDetail;
            await Navigation.PushAsync(new GroupMemberDetailPage(memberDetail));
            groupsDetailView.SelectedItem = null;
        }
    }
}