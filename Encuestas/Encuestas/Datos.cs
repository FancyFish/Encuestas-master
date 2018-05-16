

namespace Encuestas
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using Xamarin.Forms;

    public class Datos:Notificable
    {
        public Datos()
        {
            MessagingCenter.Subscribe<ContentPage,
            Encuesta>(this, Mensajes.EncuestaCompleta, (sender, args)
            =>
            {
                encuestas.Add((Encuesta)args);
            });
        }
        private ObservableCollection<Encuesta> encuestas;
        
        #region Propiedades
        public ObservableCollection<Encuesta> Encuestas
        {
            get
            {
                return encuestas;
            }
            set
            {
                if (encuestas == value)
                {
                    return;
                }
                encuestas = value;
                OnPropertyChanged();
            }

        }
        #endregion
        #region metodos
        public void agregarEncuesta(Encuesta e) {
            encuestas.Add(e);
            OnPropertyChanged();
        }
        #endregion
    }


}
