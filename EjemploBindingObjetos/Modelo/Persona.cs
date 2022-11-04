using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBindingObjetos.Modelo
{
    class Persona : INotifyPropertyChanged
    {
        private int? edad;

        public event PropertyChangedEventHandler PropertyChanged;
        public int? Edad { 
            get { return edad; }
            
            set 
            {
                if (this.edad != value)
                {
                    edad = value;
                    this.NotifyPropertyChanged("Edad");
                }
            }
        }

        public string Nombre { get; set; }

        public Persona() { }

        public Persona(string nombre, int edad)
        {
            Edad = edad;
            Nombre = nombre;
        }
        private void NotifyPropertyChanged(string v)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }
    }
}
