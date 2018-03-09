using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Android.Locations;
using ParPorApp.Models;
using ParPorApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParPorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //public class ApiGroup
    //{
    //    public string Description { get; set; }
        
    //    public string DistrictId { get; set; }
        
    //    public long Id { get; set; }
        
    //    public string Name { get; set; }
    //}

    
    public partial class GroupsPage : ContentPage
    {

        //private const string Url = "http://localhost:55000/api/groups";
        //private HttpClient _client = new HttpClient();
        //private ObservableCollection<ApiGroup> _groups;

        public ObservableCollection<string> Items { get; set; }

        public GroupsPage()
        {
            InitializeComponent();

            groupView.ItemsSource = new List<Newsfeed>
            {
                new Newsfeed{ Name = "Coach Ashley O'Toole", ImageUrl = "https://ui-avatars.com/api/?background=c357&color=fff&name=A+O", GameIcon = "volleyball.jpg", Description = "Game", PostDate = "09:12AM  03/12/2018", EventDate = "07:00PM  03/18/2018", HomeTeamLogo = "milford.png", AwayTeamLogo = "princeton.png", HomeTeamName = "Milford Volleyball", AwayTeamName = "Princeton Volleyball", Location = "5735 Wolfpen Pleasant Hill Rd, Milford, OH 45150", VS = "VS", Note = "Note: Please be at the location half an hour early to do warm up!"},
                new Newsfeed{ Name = "Catherine Mason", ImageUrl = "https://ui-avatars.com/api/?background=c334&color=ffff&name=C+M", GameIcon = "football.png", Description = "Post", Note = "We had a great game last Saturday. I wanted to thank all of you for the great support and effort... GO TEAM!", PostDate = "7:53AM  05/18/2018"},
                new Newsfeed{ Name = "Coach Stephen", ImageUrl = "https://ui-avatars.com/api/?background=a457&color=ffff&name=A+S", GameIcon = "soccer.png", Description = "Practice", PostDate = "7:53AM  02/18/2018", EventDate = "7:53AM  05/18/2018"},
                new Newsfeed{ Name = "Coach Mark", ImageUrl = "https://ui-avatars.com/api/?background=2267&color=ffff&name=A+A", GameIcon = "basketball.png", Description = "Practice", PostDate = "12:21PM  02/17/2018", EventDate = "7:53AM  05/18/2018"},
                
            };
            //{
            //    new Group{ Name = "Ashley O'Toole", ImageUrl = "https://ui-avatars.com/api/?background=c357&color=fff&name=A+O", gameIcon = "volleyball", Description = "Main O'Toole's parent"},
            //    new Group{ Name = "Andrue Stephen", ImageUrl = "https://ui-avatars.com/api/?background=a457&color=ffff&name=A+S", Description = "Carlie Stephen's parent"},
            //    new Group{ Name = "Alexis Alper", ImageUrl = "https://ui-avatars.com/api/?background=2267&color=ffff&name=A+A", Description = "Addison Alper's parent"},
            //    new Group{ Name = "Rhonda Shay", ImageUrl = "https://ui-avatars.com/api/?background=6737&color=ffff&name=R+S", Description = "Caitlyn Shay's parent"},
            //    new Group{ Name = "Catherine Mason", ImageUrl = "https://ui-avatars.com/api/?background=c334&color=ffff&name=C+M", Description = "Allison's parent"},
            //    new Group{ Name = "Elise Wene", ImageUrl = "https://ui-avatars.com/api/?background=e461&color=ffff&name=E+W", Description = "Grace Wene's parent"},
            //    new Group{ Name = "Hannah Kemen", ImageUrl = "https://ui-avatars.com/api/?background=4654&color=ffff&name=H+K", Description = "Haley Kemen's parent"},
            //    new Group{ Name = "Kacey Bail", ImageUrl = "https://ui-avatars.com/api/?background=f2d1&color=ffff&name=K+B", Description = "Charlie Steven's parent"}
            //};
            base.OnAppearing();

	        //groupView.ItemsSource = new List<Place>
	        //{
	        //    new Place {Address = "5735 Wolfpen Pleasant Hill Rd, Milford, OH 45150"}
	        //};
        }
        //protected override async void OnAppearing()
        //{
        //    var content = await _client.GetStringAsync(Url);
        //    var groups = JsonConvert.DeserializeObject<List<ApiGroup>>(content);
        //    _groups = new ObservableCollection<ApiGroup>(groups);
        //    groupView.ItemsSource = _groups;


        //}
        
        async void NewsfeedView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var contact = e.SelectedItem as Newsfeed;
            await Navigation.PushAsync(new ContactDetailPage(contact));
            groupView.SelectedItem = null;
        }
    }
}
