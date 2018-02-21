using System.Windows.Input;
using ParPorApp.Helpers;
using ParPorApp.Services;
using Xamarin.Forms;

namespace ParPorApp.ViewModels
{
    public class LoginViewModel : Page
    {
        private ApiServices _apiServices = new ApiServices();
        public string Username { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var accesstoken = await ApiServices.LoginAsync(Username, Password);
                    
                    Settings.AccessToken = accesstoken;
                    
                });
            }
        }

        internal ApiServices ApiServices { get => _apiServices; set => _apiServices = value; }

        public LoginViewModel()
        {
            Username = Settings.Username;
            Password = Settings.Password;
        }

    }
}

