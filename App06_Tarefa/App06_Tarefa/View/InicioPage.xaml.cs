using App06_Tarefa.Model;
using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App06_Tarefa.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioPage : ContentPage
    {
        public InicioPage()
        {
            InitializeComponent();

            CultureInfo culture = new CultureInfo("pt-BR");
            lblData.Text = string.Format(DateTime.Now.ToString("dddd, dd {0} MMMM {0} yyyy", culture), "de");

            GetTarefa();
        }

        private void GetTarefa()
        {
            slTarefa.Children.Clear();
            int i = 0;
            foreach (var item in new Gerenciar().tarefas())
            {
                linhaStack(item, i);
                i++;
            }
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroPage());
        }

        public void linhaStack(Tarefa t, int i)
        {
            Image delete = new Image()
            {
                VerticalOptions = LayoutOptions.Center,
                Source = ImageSource.FromFile(
                    Device.RuntimePlatform == Device.UWP? 
                    "Resources/Delete.png" :
                    "Delete.png"),
            };
            TapGestureRecognizer tapped = new TapGestureRecognizer();
            tapped.Tapped += delegate
            {
                new Gerenciar().remover(i);
                GetTarefa();
            };
            delete.GestureRecognizers.Add(tapped);
            Image prioridade = new Image()
            {
                VerticalOptions = LayoutOptions.Center,
                Source = ImageSource.FromFile(
                    Device.RuntimePlatform == Device.UWP ? 
                    "Resources/p" + t.Prioridade + ".png" :
                    "p" + t.Prioridade + ".png" )
            };
            Image check = new Image()
            {
                VerticalOptions = LayoutOptions.Center,
                Source = ImageSource.FromFile(
                    Device.RuntimePlatform == Device.UWP ?
                    "Resources/CheckOff.png": 
                    "CheckOff.png")
            };
            Xamarin.Forms.View text = null;
            if (t.Finalizacao == null)
            {
                text = new Label()
                {
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Text = t.Nome
                };
            }
            else
            {
                check.Source = ImageSource.FromFile(
                    Device.RuntimePlatform == Device.UWP ?
                    "Resources/CheckOn.png" :
                    "CheckOn.png");
                text = new StackLayout()
                {
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Spacing = 0
                };
                ((StackLayout)text).Children.Add(new Label()
                {
                    Text = t.Nome,
                    TextColor = Color.Gray
                });
                ((StackLayout)text).Children.Add(new Label()
                {
                    Text = "Finalizado em " + t.Finalizacao.Value.ToString("dd/MM/yyyy - hh:mm") + "h",
                    TextColor = Color.Gray,
                    FontSize = 10
                });
            }
            TapGestureRecognizer tappedcheck = new TapGestureRecognizer();
            tappedcheck.Tapped += delegate
            {
                new Gerenciar().finalizar(i, t);
                GetTarefa();
            };
            check.GestureRecognizers.Add(tappedcheck);
            StackLayout stack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Spacing = 15,
            };
            stack.Children.Add(check);
            stack.Children.Add(text);
            stack.Children.Add(prioridade);
            stack.Children.Add(delete);

            slTarefa.Children.Add(stack);
        }
    }
}