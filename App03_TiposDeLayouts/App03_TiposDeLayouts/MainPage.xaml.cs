using App03_TiposDeLayouts.View;
using System;
using Xamarin.Forms;

namespace App03_TiposDeLayouts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnStack_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayoutPage());
        }

        private void btnGrid_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridPage());
        }

        private void btnAbsolute_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayoutPage());
        }

        private void btnRelative_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RelativeLayoutPage());
        }

        private void btnScroll_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScrollViewPage());
        }
    }
}