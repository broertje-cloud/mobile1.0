using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace mobile1._0
{

    public class ShowPasswordTriggerAction : TriggerAction<ImageButton>, INotifyPropertyChanged
    {
        public string ShowIcon { get; set; }
        public string HideIcon { get; set; }
        bool _hidePassword = true;
        public bool HidePassword
        {
            set
            {
                if (_hidePassword != value)
                {
                    _hidePassword = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HidePassword)));
                }
            }
            get => _hidePassword;
        }
        protected override void Invoke(ImageButton sender)
        {
            sender.Source = HidePassword ? ShowIcon : HideIcon;
            HidePassword = !HidePassword;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
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
