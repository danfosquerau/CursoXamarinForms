using App02_TiposDePaginas.View.Carousel;
using Xamarin.Forms;

namespace App02_TiposDePaginas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new IntroPage()
            {
                BackgroundColor = (Color)Current.Resources["ColorAccent"]
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}