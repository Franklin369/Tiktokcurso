using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Tiktokcurso.Datos;
using Tiktokcurso.Modelo;

using Xamarin.Forms;

namespace Tiktokcurso.VistaModelo
  {

  public class VMvreproductor : BaseViewModel
    {
    #region VARIABLES

    ObservableCollection<Mvideos> _lista;
    #endregion
    #region CONSTRUCTOR
    public VMvreproductor(INavigation navigation)
      {
      Navigation=navigation;
      MostrarLista();
      }
    #endregion
    #region OBJETOS
    public ObservableCollection<Mvideos> Lista
      {
      get { return _lista; }
      set { SetValue(ref _lista,value); }
      }
    #endregion
    #region PROCESOS
    public void MostrarLista()
      {
      var funcion = new Dvideos();
      Lista=funcion.Mostrarvideos();
      }
  
    #endregion
    #region COMANDOS
  
    #endregion
    }

  }
