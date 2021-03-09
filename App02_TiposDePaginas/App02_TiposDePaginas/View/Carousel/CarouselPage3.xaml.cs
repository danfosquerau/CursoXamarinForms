using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TiposDePaginas.View.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPage3 : ContentPage
    {
        public CarouselPage3()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new NavigationPage(new Navigation.Page1());
            //{
            //    BarBackgroundColor = Color.Blue
            //};

            Application.Current.MainPage = new Master.MasterPage();
        }
    }
}