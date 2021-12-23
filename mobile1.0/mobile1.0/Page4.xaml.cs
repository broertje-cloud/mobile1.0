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

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Accelerometer.ShakeDetected += Accelerometer_ShakeDetected;

            Accelerometer.Start(SensorSpeed.Game);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Connectivity.ConnectivityChanged -= Connectivity_ConnectivityChanged;
            Accelerometer.ShakeDetected -= Accelerometer_ShakeDetected;
            Accelerometer.Stop();

        }

        private void Accelerometer_ShakeDetected(object sender, EventArgs e)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                passwoordEntry.Text = string.Empty;
                usernameEntry.Text = string.Empty;
            });
        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    
}