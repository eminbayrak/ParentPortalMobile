using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ParPorApp.Helpers;
using ParPorApp.Models;
using ParPorApp.Services;
using Xamarin.Forms;

namespace ParPorApp.ViewModels
{
	public class UserViewModel : INotifyPropertyChanged
	{
		private readonly ApiServices _apiServices = new ApiServices();
		private User _users;

		public User Users
		{
			get => _users;
			set
			{
				_users = value;
				OnPropertyChanged();
			}
		}

		public ICommand GetUserCommand
		{
			get
			{
				return new Command(async () =>
				{
					var accessToken = Settings.AccessToken;
					Users = await _apiServices.GetUsersAsync(accessToken);
				});
			}
		}

		public static ICommand LogoutCommand
		{
			get
			{
				return new Command(() =>
				{
					Settings.AccessToken = String.Empty;
					//debug.writeline(settings.username);
					Settings.Password = String.Empty;
					// navigate to LoginPage
				});
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
