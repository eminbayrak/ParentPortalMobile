using System;
using System.Threading.Tasks;
using Acr.UserDialogs;
using ParPorApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParPorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    
    public partial class GroupPage : ContentPage
    {
        GroupsViewModel groupsViewModel;
        public GroupPage()
        {
            InitializeComponent();

            
            BindingContext = groupsViewModel = new GroupsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            groupsViewModel.GetGroupsCommand.Execute(null);
        }

        //private async void LogoutMenuItem_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new LoginPage());
        //}
        async void GroupsView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            using (UserDialogs.Instance.Loading("Loading...", null, null, true, MaskType.Black))
            {
                await Task.Delay(500);
                if (e.SelectedItem == null)
                    return;
                var contact = e.SelectedItem as GroupsDetail;
                await Navigation.PushAsync(new GroupDetailPage());
                groupsListView.SelectedItem = null;
            }
                
        }
    }
}