using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tiktokcurso.Vistas.Reproductor;
namespace Tiktokcurso
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Vreproductor();
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
