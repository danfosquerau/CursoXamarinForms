using App05_ControlesVisuais.Model;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05_ControlesVisuais.View.VisualControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            List<Person> list = new List<Person>();
            list.Add(new Person() { nome = "Jose", idade = "20" });
            list.Add(new Person() { nome = "Maria", idade = "22" });
            list.Add(new Person() { nome = "Felipe", idade = "21" });
            list.Add(new Person() { nome = "Paulo", idade = "26" });

            lvwPerson.ItemsSource = list;
        }
    }
}