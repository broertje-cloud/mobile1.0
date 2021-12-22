using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobile1._0
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Page4 : ContentPage
{
    public Page4()
    {
        InitializeComponent();
    }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void ButtonVibrate_Clicked(object sender, EventArgs e)
        {
            Vibration.Vibrate(TimeSpan.FromMilliseconds(SliderTime.Value));
        }

        private void ButtonCancel_Clicked(object sender, EventArgs e)
        {
            Vibration.Cancel();
        }
    }
}