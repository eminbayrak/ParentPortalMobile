using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParPorApp.ViewModels;
using Plugin.LocalNotifications;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParPorApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddEventPage : ContentPage
	{
		public AddEventPage ()
		{
			InitializeComponent ();
            //BindingContext = new GroupsViewModel();
		    //takePhoto.Clicked += async (sender, args) =>
		    //{

		    //    if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
		    //    {
		    //        await DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
		    //        return;
		    //    }

		    //    var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
		    //    {
		    //        Directory = "Test",
		    //        SaveToAlbum = true,
		    //        CompressionQuality = 75,
		    //        CustomPhotoSize = 50,
		    //        PhotoSize = PhotoSize.MaxWidthHeight,
		    //        MaxWidthHeight = 2000,
		    //        DefaultCamera = CameraDevice.Front
		    //    });

		    //    if (file == null)
		    //        return;

		    //    await DisplayAlert("File Location", file.Path, "OK");

		    //    image.Source = ImageSource.FromStream(() =>
		    //    {
		    //        var stream = file.GetStream();
		    //        file.Dispose();
		    //        return stream;
		    //    });
		    //};

		    //pickPhoto.Clicked += async (sender, args) =>
		    //{
		    //    if (!CrossMedia.Current.IsPickPhotoSupported)
		    //    {
      //              await DisplayAlert("Photos Not Supported", ":( Permission not granted to photos.", "OK");
		    //        return;
		    //    }
		    //    var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
		    //    {
		    //        PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,

		    //    });


		    //    if (file == null)
		    //        return;

		    //    image.Source = ImageSource.FromStream(() =>
		    //    {
		    //        var stream = file.GetStream();
		    //        file.Dispose();
		    //        return stream;
		    //    });
		    //};
        }

	    private void DatePicker_StartDateSelected(object sender, DateChangedEventArgs e)
	    {
	        StartDate.Text = e.NewDate.Month.ToString() + "/" + e.NewDate.Day.ToString() + "/" + e.NewDate.Year.ToString() + " " + StartTime.Time.ToString();
        }

	    private void DatePicker_FinishDateSelected(object sender, DateChangedEventArgs e)
	    {
	        FinishDate.Text = e.NewDate.Month.ToString() + "/" + e.NewDate.Day.ToString() + "/" + e.NewDate.Year.ToString() + " " + EndTime.Time.ToString();
	    }

        private async Task ReturnEventPage_Clicked(object sender, EventArgs e)
		{
            await Task.Delay(3000);
		    await Navigation.PushAsync(new EventsPage());
		    CrossLocalNotifications.Current.Show("New Event!", "A new content has posted.", 1, DateTime.UtcNow.AddSeconds(8));
        }

	}
}