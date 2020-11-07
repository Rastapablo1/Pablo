using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Loginsemana3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PantallaInicio : ContentPage
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void btnSaludo_Clicked(object sender, EventArgs e)
        {

            string Text = txtNombre.Text;
            string mensaje = "Hola " + Text;
            DisplayAlert("Saludos", mensaje, "OK");
        }
    }
}