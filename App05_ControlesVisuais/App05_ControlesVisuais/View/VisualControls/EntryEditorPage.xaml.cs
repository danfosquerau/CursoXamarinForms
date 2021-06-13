using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05_ControlesVisuais.View.VisualControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryEditorPage : ContentPage
    {
        public EntryEditorPage()
        {
            InitializeComponent();

            txtAge.TextChanged += delegate (object senger, TextChangedEventArgs args)
            {
                lblDuplicado.Text = args.NewTextValue;
            };

            txtComentario.Completed += delegate (object senger, EventArgs args)
            {
                lblQuantidadeCaractere.Text = txtComentario.Text.Length.ToString();
            };
        }
    }
}