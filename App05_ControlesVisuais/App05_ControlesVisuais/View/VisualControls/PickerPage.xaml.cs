using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05_ControlesVisuais.View.VisualControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerPage : ContentPage
    {
        public PickerPage()
        {
            InitializeComponent();
        }

        private void pckInfo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Picker obj = (Picker)sender;
            lblResult.Text = obj.SelectedItem.ToString() + " - " + obj.SelectedIndex.ToString();
        }
    }
}