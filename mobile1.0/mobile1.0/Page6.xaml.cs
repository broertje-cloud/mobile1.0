﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobile1._0
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Page6 : ContentPage
{
    public Page6()
    {
        InitializeComponent();
    }


        private void HomeButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Homepage());
        }
    }
}