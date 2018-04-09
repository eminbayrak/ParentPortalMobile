using Acr.UserDialogs;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using FFImageLoading.Forms.Droid;
using IconEntry.FormsPlugin.Android;
using Microsoft.WindowsAzure.MobileServices;
using Plugin.LocalNotifications;
using ScnViewGestures.Plugin.Forms.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace ParPorApp.Droid
{
    [Activity(Label = "ParPorApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = false,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            UserDialogs.Init(this);
			base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            //Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
            Forms.Init(this, bundle);
            CurrentPlatform.Init();
            LoadApplication(new App());

            IconEntryRenderer.Init();
            LocalNotificationsImplementation.NotificationIconId = Resource.Drawable.ic_logo;
            CachedImageRenderer.Init(enableFastRenderer: true);
            ViewGesturesRenderer.Init();

            //Window.AddFlags(WindowManagerFlags.LayoutNoLimits);
            //Window.AddFlags(WindowManagerFlags.LayoutInScreen);
            //Window.DecorView.SetFitsSystemWindows(true);

        }
        
}
}