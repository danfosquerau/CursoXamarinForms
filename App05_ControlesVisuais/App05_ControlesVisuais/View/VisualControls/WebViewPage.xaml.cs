using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05_ControlesVisuais.View.VisualControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
        }

        private void btnOk_Clicked(object sender, System.EventArgs e)
        {
            web.Source = txtUrl.Text;
        }

        private void btnPrevious_Clicked(object sender, System.EventArgs e)
        {
            if (web.CanGoBack)
                web.GoBack();
        }

        private void btnNext_Clicked(object sender, System.EventArgs e)
        {
            if (web.CanGoForward)
                web.GoForward();
        }

        private void web_Navigating(object sender, WebNavigatingEventArgs e)
        {
            lblStatus.Text = "Carregando...";
        }

        private void web_Navigated(object sender, WebNavigatedEventArgs e)
        {
            lblStatus.Text = "Finalizado";
        }

        //        A partir do Android 9 o Google alterou uma propriedade de configuração,
        //        que se chama android:usesCleartextTraffic e server para controlar o acesso
        //        do aplicativo a sites sem criptografia.No Android 8 esse atributo vem como true,
        //        permitindo o seu WebView acesso sites que não utilizam criptografia(HTTP),
        //        no Android 9 esse atributo vem como false, assim temos que mudar para true manualmente
        //        no AndroidManifest.xml para que nosso WebView acesse sites HTTP sem criptografia.
        //
        //          AndroidManifest.xml > Tag<application>   >
        //          Adicionar atributo android:usesCleartextTraffic= "true".

        //       No iOS para autorizar o acesso a várias páginas é necessário adicionar
        //       uma chave-valor no arquivo info.plist.
        //
        //       <key>NSAppTransportSecurity</key>
        //       <dict>
        //          <key>NSAllowsArbitraryLoads</key>
        //          <true/>
        //      </dict>


    }
}