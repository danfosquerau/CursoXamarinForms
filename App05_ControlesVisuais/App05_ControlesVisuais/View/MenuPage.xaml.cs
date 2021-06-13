using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05_ControlesVisuais.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
#pragma warning disable CS0618 // 'MasterDetailPage' is obsolete: 'MasterDetailPage is obsolete as of version 5.0.0. Please use FlyoutPage instead.'
    public partial class MenuPage : MasterDetailPage
#pragma warning restore CS0618 // 'MasterDetailPage' is obsolete: 'MasterDetailPage is obsolete as of version 5.0.0. Please use FlyoutPage instead.'
    {
        public MenuPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
        }

        private void btnActivityIndicator_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new VisualControls.ActivityIndicatorPage());
            IsPresented = false;
        }

        private void btnProgressBar_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new VisualControls.ProgressBarPage());
            IsPresented = false;
        }

        private void btnBoxView_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new VisualControls.BoxViewPage());
            IsPresented = false;
        }

        private void btnLabel_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new VisualControls.LabelPage());
            IsPresented = false;
        }

        private void btnButton_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new VisualControls.ButtonPage());
            IsPresented = false;
        }

        private void btnEntryEditor_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new VisualControls.EntryEditorPage());
            IsPresented = false;
        }

        private void btnDatePicker_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new VisualControls.DatePickerPage());
            IsPresented = false;
        }

        private void btnTimePicker_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new VisualControls.TimePickerPage());
            IsPresented = false;
        }

        private void btnPicker_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new VisualControls.PickerPage());
            IsPresented = false;
        }

        private void btnSearchBar_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new VisualControls.SearchBarPage());
            IsPresented = false;
        }

        private void btnSliderStepper_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new VisualControls.SliderStepperPage());
            IsPresented = false;
        }

        private void btnSwitch_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new VisualControls.SwitchPage());
            IsPresented = false;
        }

        private void btnImage_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new VisualControls.ImagePage());
            IsPresented = false;
        }

        private void btnListView_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new VisualControls.ListViewPage());
            IsPresented = false;
        }

        private void btnTableView_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new VisualControls.TableViewPage());
            IsPresented = false;
        }

        private void btnWebView_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new VisualControls.WebViewPage());
            IsPresented = false;
        }
    }
}