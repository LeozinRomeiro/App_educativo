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
    public partial class Page_numeros : ContentPage
    {
        public Page_numeros()
        {
            InitializeComponent();
        }

        public void botao_cores_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page_cores());
        }

    }
}