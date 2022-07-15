using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using Tiktokcurso.Modelo;

namespace Tiktokcurso.Datos
  {
  public class Dvideos
    {
    public  ObservableCollection <Mvideos>Mostrarvideos()
      {
      return new ObservableCollection<Mvideos>()
        {
        new Mvideos()
          {
          video="https://firebasestorage.googleapis.com/v0/b/tiktok-2955b.appspot.com/o/v1.mp4?alt=media&token=f87f7b92-7822-4d87-9ff7-265e402181b9"
          },
        new Mvideos()
          {
          video="https://firebasestorage.googleapis.com/v0/b/tiktok-2955b.appspot.com/o/v2.mp4?alt=media&token=ceff7ac6-dc09-437e-9778-5c82c99b3506"
          },
          new Mvideos()
          {
          video="https://firebasestorage.googleapis.com/v0/b/tiktok-2955b.appspot.com/o/v3.mp4?alt=media&token=fd83895a-0b7b-441e-b69c-6c6cad7c3c82"
          }
        };
      }
    }
  }
