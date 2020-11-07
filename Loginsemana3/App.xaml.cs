using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Loginsemana3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            PantallaInicio = new PantallaInicio();
            Ejercicio1 = new Ejercicio1();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
