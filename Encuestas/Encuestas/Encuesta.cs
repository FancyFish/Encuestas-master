using System;
using System.Collections.Generic;
using System.Text;

namespace Encuestas
{
     public class Encuesta :Notificable
    {
        #region Atributos
       
        private string nombre;
        private DateTime fechaNacimiento;
        private string equipo;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged("Nombre");
            }
            
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                if (fechaNacimiento == value)
                {
                    return;
                }
                fechaNacimiento = value;
                OnPropertyChanged("FechaNacimiento");
            }

        }
       
        public string Equipo
        {
            get { return equipo; }
            set {
                if (equipo == value) {
                    return;
                }
                equipo = value;
                OnPropertyChanged("Equipo");
            }
        }

        #endregion

        #region Propiedades

        
        #endregion

        #region Metodos
      

        #endregion

    }
}
