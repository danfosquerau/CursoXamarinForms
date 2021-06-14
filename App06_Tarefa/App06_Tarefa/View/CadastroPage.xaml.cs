using App06_Tarefa.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App06_Tarefa.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroPage : ContentPage
    {
        private byte p { get; set; } = 0;

        public CadastroPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            var stacks = slPrioridades.Children;
            foreach (var item in stacks)
            {
                Label label = ((StackLayout)item).Children[1] as Label;
                label.TextColor = Color.Gray;
            }
            ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;
            FileImageSource img = ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;
            string s = img.File.ToString().Replace(".png", "").Replace("p", "").Replace("Resources/","");
            p = byte.Parse(s);
        }

        private void btnOk_Clicked(object sender, System.EventArgs e)
        {
            bool flag = false;
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrWhiteSpace(txtNome.Text))
            {
                flag = true;
                DisplayAlert("Erro", "Nome não preenchido.", "Ok");
            }
            if (!(p > 0))
            {
                flag = true;
                DisplayAlert("Erro", "Prioridade não informada.", "Ok");
            }
            if (!flag)
            {
                Tarefa t = new Tarefa()
                {
                    Nome = txtNome.Text,
                    Prioridade = p
                };
                new Gerenciar().salvar(t);

                Application.Current.MainPage = new NavigationPage(new InicioPage());
            }
        }
    }
}