using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParPorApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPageMaster : ContentPage
	{
		public ListView ListView;

		public MainPageMaster()
		{
			InitializeComponent();

			BindingContext = new MainPageMasterViewModel();
			ListView = MenuItemsListView;
		}

		class MainPageMasterViewModel : INotifyPropertyChanged
		{
			public ObservableCollection<MainPageMenuItem> MenuItems { get; set; }

			public MainPageMasterViewModel() => MenuItems = new ObservableCollection<MainPageMenuItem>(new[]
			{

				new MainPageMenuItem { Id = 0, Title = "Groups", IconSource="ic_group.png", TargetType=typeof(GroupPage)},
				new MainPageMenuItem { Id = 1, Title = "Contacts", IconSource="ic_contact.png", TargetType=typeof(SocialPage)},
				new MainPageMenuItem { Id = 2, Title = "Events", IconSource="ic_message.png", TargetType=typeof(EventsPage) },
				new MainPageMenuItem { Id = 3, Title = "My Profile", IconSource="ic_group.png", TargetType=typeof(UserProfilePage) },
				new MainPageMenuItem { Id = 4, Title = "Events", IconSource="ic_event.png", TargetType=typeof(AddEventPage) }
			});

			#region INotifyPropertyChanged Implementation
			public event PropertyChangedEventHandler PropertyChanged;
			void OnPropertyChanged([CallerMemberName] string propertyName = "")
			{
				if (PropertyChanged == null)
					return;

				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
			#endregion
		}

		private async void LogoutMenuItem_Clicked(object sender, EventArgs e)
		{

			await Navigation.PushAsync(new LoginPage());
		}
	}
}