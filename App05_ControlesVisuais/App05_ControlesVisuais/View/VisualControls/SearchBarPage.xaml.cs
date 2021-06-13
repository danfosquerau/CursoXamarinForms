using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05_ControlesVisuais.View.VisualControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarPage : ContentPage
    {
        private List<String> list;

        public SearchBarPage()
        {
            InitializeComponent();

            list = new List<String>();
            list.Add("Microsoft");
            list.Add("Apple");
            list.Add("Oracle");
            list.Add("IBM");
            list.Add("SAP");
            list.Add("Uber");
            list.Add("99Taxi");

            Preencher(list);
        }

        private void Preencher(List<String> vs)
        {
            listResult.Children.Clear();
            foreach (var item in vs)
            {
                listResult.Children.Add(new Label { Text = item });
            }
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var result = list.Where(x => x.Contains(e.NewTextValue)).ToList();
            Preencher(result);
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var result = list.Where(x => x.Contains((sender as SearchBar).Text)).ToList();
            Preencher(result);
        }
    }
}