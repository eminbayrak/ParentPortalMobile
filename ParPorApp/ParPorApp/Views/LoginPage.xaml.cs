﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ParPorApp.Helpers;
using ParPorApp.ViewModels;
using RestSharp.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParPorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            EmailEntry.Completed += (sender, args) => { PasswordEntry.Focus(); };
            PasswordEntry.Completed += (sender, args) => { LoginButton.Focus(); };

            
        }


        private void ForgotPwdButton_OnClicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
    }

}