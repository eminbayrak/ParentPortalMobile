using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ParPorApp.Models;
using ParPorApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParPorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class NewsfeedPage : ContentPage
    {  
        public ObservableCollection<string> Items { get; set; }

        public NewsfeedPage()
        {
            InitializeComponent();

            newsfeedView.ItemsSource = new List<Newsfeed>
            {
                new Newsfeed{ Name = "Coach Ashley", ImageUrl = "http://randomuser.me/api/portraits/med/women/19.jpg", GameIcon = "soccer.png", Description = "Game", PostDate = "03/12/2018 09:12AM", EventDate = "03/18/2018 07:00PM", HomeTeamLogo = "milford.png", AwayTeamLogo = "princeton.png", HomeTeamName = "Milford Volleyball", AwayTeamName = "Princeton Volleyball", Location = "5735 Wolfpen Pleasant Hill Rd, Milford, OH 45150", VS = "VS", Latitude = 39.181544, Longitude = -84.237503, Note = "Note: Please be at the location half an hour early to do warm up!"},
                new Newsfeed{ Name = "Catherine Mason", ImageUrl = "https://ui-avatars.com/api/?background=c334&color=ffff&name=C+M", GameIcon = "football.png", Description = "Post", Note = "We had a great game last Saturday. I wanted to thank all of you for the great support and effort... GO TEAM!", PostDate = "03/18/2018 7:53AM"},
                new Newsfeed{ Name = "Coach Stephen", ImageUrl = "https://ui-avatars.com/api/?background=a457&color=ffff&name=A+S", GameIcon = "volleyball.png", Description = "Practice", PostDate = "02/18/2018 7:53AM", EventDate = "05/18/2018 7:53AM"},
                new Newsfeed{ Name = "Coach Mark", ImageUrl = "https://ui-avatars.com/api/?background=2267&color=ffff&name=A+A", GameIcon = "basketball.png", Description = "Practice", PostDate = "02/17/2018 12:21PM", EventDate = "05/18/2018 7:53AM"},
                
            };

           
            base.OnAppearing();
        }
        async void NewsfeedView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var contact = e.SelectedItem as Newsfeed;
            await Navigation.PushAsync(new NewsfeedDetailPage(contact));
            newsfeedView.SelectedItem = null;
        }
    }
}
