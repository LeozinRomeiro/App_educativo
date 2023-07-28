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
    public partial class Page_familia : ContentPage
    {
        public Page_familia()
        {
            InitializeComponent();
        }
        private void botao_sair_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

    }
}