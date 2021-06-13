using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05_ControlesVisuais.View.VisualControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgressBarPage : ContentPage
    {
        public ProgressBarPage()
        {
            InitializeComponent();
        }

        private void btnModify_Clicked(object sender, System.EventArgs e)
        {
            bar1.Progress = 1;
            bar2.ProgressTo(1, 5000, Easing.Linear);
            bar3.ProgressTo(1, 5000, Easing.SpringIn);
        }
    }
}