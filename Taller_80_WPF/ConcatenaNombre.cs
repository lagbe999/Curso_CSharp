using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_80_WPF
{
    public class ConcatenaNombre : INotifyPropertyChanged
    {
        private string nombre, apellido, nombre_completo;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; OnPropertyChanged("NombreCompleto"); }



        }

        public string Apellido
        {
            get { return apellido; }

            set { apellido = value; OnPropertyChanged("NombreCompleto"); }
        }

        public string NombreCompleto
        {
            get { nombre_completo = Nombre + " " + Apellido; return nombre_completo; }

            set { }
        }


    }
}
