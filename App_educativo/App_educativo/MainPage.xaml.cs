using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_educativo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void botao_cores_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page_cores());
        }

        public void botao_familia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page_familia());
        }

        public void botao_numeros_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page_numeros());
        }

        private void botao_sair_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
