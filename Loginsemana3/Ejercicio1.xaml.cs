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
    public partial class Ejercicio1 : ContentPage
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Sumar_Clicked(object sender, EventArgs e)
        {
            try {
                double dato1 = Convert.ToDouble(txtDato1.Text);
                double dato2 = Convert.ToDouble(txtDato2.Text);
                double suma = dato1 + dato2;

                txtResultado.Text = Sumar.ToString(); 
            }
            catch (Exception ex) {
                DisplayAlert("Mensaje", "ERROR" + ex.Message, "OK");
            }
    }
}