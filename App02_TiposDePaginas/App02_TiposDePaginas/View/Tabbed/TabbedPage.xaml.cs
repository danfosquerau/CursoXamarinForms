using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using x = Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TiposDePaginas.View.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage : x.TabbedPage
    {
        public TabbedPage()
        {
            InitializeComponent();

            Children.Add(new Navigation.Page1()
            {
                IconImageSource = x.Device.RuntimePlatform == x.Device.UWP? "Resources//item_3.png": "item_3.png",
                Title = "Item 3"
            });
        }
    }
}