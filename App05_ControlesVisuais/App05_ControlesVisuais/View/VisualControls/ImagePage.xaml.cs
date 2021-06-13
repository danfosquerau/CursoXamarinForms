using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05_ControlesVisuais.View.VisualControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            //img1.IsLoading

            Image imgUsb = new Image();
            if (Device.RuntimePlatform == Device.UWP)
                imgUsb.Source = ImageSource.FromFile("Resources/usb.jpg");
            else
                imgUsb.Source = ImageSource.FromFile("usb.jpg");

            container.Children.Add(imgUsb);
        }
    }
}