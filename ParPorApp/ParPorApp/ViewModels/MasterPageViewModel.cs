using System;
using System.Collections.Generic;
using System.Text;
using ParPorApp.Views;
using Xamarin.Forms;

namespace ParPorApp.ViewModels
{
    public class MasterPageViewModel
    {
        public UserViewModel UserViewModel { get; set; }
        public MainPageMaster.MainPageMasterViewModel MainPageMasterViewModel { get; set; }
    }
}
