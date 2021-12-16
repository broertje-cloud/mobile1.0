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
    public partial class Homepage : TabbedPage
    {
    public Homepage()
    {
        InitializeComponent();
    }



        private void HelpToolbarItem_Clicked(object sender, EventArgs e)
        {
            
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }


}