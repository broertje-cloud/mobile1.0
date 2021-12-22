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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Sms.ComposeAsync(new SmsMessage(EntryMessage.Text,
                    EntryNumber.Text));
            }
            catch (Exception)
            {

            }   

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
                EntryNumber.Text = string.Empty;
                EntryMessage.Text = string.Empty;
            });
        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }

}