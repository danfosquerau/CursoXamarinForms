using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App04_Xamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new ProfilePage());
            IsPresented = false;
        }

        private void Button_Clicked_3(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new XamarinPage());
            IsPresented = false;
        }
    }
}