using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_educativo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_cores : ContentPage
    {
        public Page_cores()
        {
            InitializeComponent();
        }

        public void botao_familia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page_familia());
        }

    }
}