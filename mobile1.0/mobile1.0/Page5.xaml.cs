using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobile1._0
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Page5 : ContentPage
{
    public Page5()
    {
        InitializeComponent();
    }

        private void LoginButton_Clicked_1(object sender, EventArgs e)
        {
            bool isUserNameEmty = string.IsNullOrEmpty(usernameEntry.Text);
            bool isLastNameEmty = string.IsNullOrEmpty(lastnameEntry.Text);
            bool isEmailEmty = string.IsNullOrEmpty(emailEntry.Text);
            bool isPasswoordEmty = string.IsNullOrEmpty(passwoordEntry.Text);
            bool isconfirmpasswoordEmty = string.IsNullOrEmpty(confirmPasswoordEntry.Text);

            if (isUserNameEmty || isLastNameEmty || isEmailEmty || isPasswoordEmty || isconfirmpasswoordEmty)
            {
                App.Current.MainPage.DisplayAlert("Register Fail", "Please enter correct username and Password", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("je kunt nu naar de login pagina", "", "Ok");
                //Navigate to Wellcom page after successfully login  
                Navigation.PushAsync(new MainPage());

            }
        }
    }
}