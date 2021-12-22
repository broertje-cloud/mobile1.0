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
public partial class Page2 : ContentPage
{
    public Page2()
    {
        InitializeComponent();
    }


        private void ChatButtonButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page7());
        }


        private void PersonONeEntry_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page6());
        }

        private void PersonTwoEntry_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page6());
        }

        private void PersonThreeEntry_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page6());
        }

        private void PersonThreeEntryQ_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page7());
        }

        private void PersonTwoEntryQ_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page7());
        }

        private void PersonONeEntryQ_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page7());
        }
    }
}