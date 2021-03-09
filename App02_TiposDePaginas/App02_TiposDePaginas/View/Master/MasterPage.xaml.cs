using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TiposDePaginas.View.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();

            //Define o estilo de apresentação do Menu Lateral ou Master
            MasterBehavior = MasterBehavior.Popover;
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Navigation.Page1());
            //Esconde o menu lateral ou master apos a troca de pagina
            IsPresented = false;
        }

        private void Button_Clicked_1(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Navigation.Page2());
            //Esconde o menu lateral ou master apos a troca de pagina
            IsPresented = false;
        }

        private void Button_Clicked_2(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new DetailPage());
            //Esconde o menu lateral ou master apos a troca de pagina
            IsPresented = false;
        }

        private void Button_Clicked_3(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Tabbed.TabbedPage());
            //Esconde o menu lateral ou master apos a troca de pagina
            IsPresented = false;
        }
    }
}