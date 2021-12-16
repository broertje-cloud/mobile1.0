﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobile1._0
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void RegistrerenButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page5());
        }

        private void LoginButton_Clicked_1(object sender, EventArgs e)
        {
            bool isUserNameEmty = string.IsNullOrEmpty(usernameEntry.Text);
            bool isPasswoordEmty = string.IsNullOrEmpty(passwoordEntry.Text);


            if (isUserNameEmty || isPasswoordEmty)
            {
                App.Current.MainPage.DisplayAlert("Login Fail", "Please enter correct username and Password", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Login Success", "", "Ok");
                //Navigate to Wellcom page after successfully login  
                App.Current.MainPage.Navigation.PushAsync(new Homepage());

            }
        }
    }
}
