using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TiposDePaginas.View.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}