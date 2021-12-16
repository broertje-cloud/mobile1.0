using Xamarin.Forms.Xaml;

namespace mobile1._0
{
    [XamlCompilation(XamlCompilationOptions.Compile), XamlFilePath("Homepage.xaml")]
    public abstract class HomepageBase 
    {
        public abstract void InitializeComponent();
    }
}