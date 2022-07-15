using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tiktokcurso.VistaModelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tiktokcurso.Vistas.Reproductor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vreproductor : ContentPage
    {
        public Vreproductor()
        {
            InitializeComponent();
      BindingContext=new VMvreproductor(Navigation);
        }
    }
}