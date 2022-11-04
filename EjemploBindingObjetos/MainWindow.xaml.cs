using EjemploBindingObjetos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EjemploBindingObjetos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona jose;
        public MainWindow()
        {
            InitializeComponent();
            jose = new Persona("Jose", 0);
            Persona[] persona = new Persona[] {
                new Persona("Jose", 20),
                new Persona("Javi", 24),
                new Persona("Ian", 21),
                new Persona("Ruben", 20),
                new Persona("Martina", 19),
                new Persona("Pablo", 29)
            };

            Formulario.DataContext = jose;
        }

        private void CumpleañosButton_Click(object sender, RoutedEventArgs e)
        {
            ((Persona)Formulario.DataContext).Edad++;
        }

        private void SaberEdadButton_Click(object sender, RoutedEventArgs e)
        {
            jose = ((Persona)Formulario.DataContext);
            MessageBox.Show("Edad: " + jose.Edad);
        }
    }
}
