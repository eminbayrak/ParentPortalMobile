using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParPorApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParPorApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserProfilePage : ContentPage
	{
		UserViewModel usersViewModel;

		public UserProfilePage ()
		{
			InitializeComponent ();
			BindingContext = usersViewModel = new UserViewModel();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			usersViewModel.GetUserCommand.Execute(null);
		}
	}
}