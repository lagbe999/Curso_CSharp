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

namespace Taller_81_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> listaPobla = new List<Poblaciones>();

            listaPobla.Add(new Poblaciones() { Poblacion1 = "Madrid", Poblacion2 = "Barcelona", Temperatura1 = 15, Temperatura2 = 25, DifTempera=10 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Tenerife", Poblacion2 = "Murcia", Temperatura1 = 12, Temperatura2 = 18, DifTempera = 6 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Burgos", Poblacion2 = "Alicante", Temperatura1 = 27, Temperatura2 = 32, DifTempera = 5 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Sevilla", Poblacion2 = "Vigo", Temperatura1 = 32, Temperatura2 = 19, DifTempera = 13 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Valencia", Poblacion2 = "San Sebastian", Temperatura1 = 35, Temperatura2 = 26, DifTempera = 9 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Canarias", Poblacion2 = "Getafe", Temperatura1 = 18, Temperatura2 = 29, DifTempera = 11 });

            listaPobla.Add(new Poblaciones() { Poblacion1 = "Bilbao", Poblacion2 = "Zaragoza", Temperatura1 = 15, Temperatura2 = 25, DifTempera = 10 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Granada", Poblacion2 = "Cordoba", Temperatura1 = 12, Temperatura2 = 18, DifTempera = 6 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Salamanca", Poblacion2 = "Palma de Mallorca", Temperatura1 = 27, Temperatura2 = 32, DifTempera = 5 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Cadiz", Poblacion2 = "Toledo", Temperatura1 = 32, Temperatura2 = 19, DifTempera = 13 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "La Coruña", Poblacion2 = "Pamplona", Temperatura1 = 35, Temperatura2 = 26, DifTempera = 9 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Gijon", Poblacion2 = "Valladolid", Temperatura1 = 18, Temperatura2 = 29, DifTempera = 11 });

            listaPobla.Add(new Poblaciones() { Poblacion1 = "Oviedo", Poblacion2 = "Segovia", Temperatura1 = 15, Temperatura2 = 25, DifTempera = 10 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Tarragona", Poblacion2 = "Cuenca", Temperatura1 = 12, Temperatura2 = 18, DifTempera = 6 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Caceres", Poblacion2 = "Logroño", Temperatura1 = 27, Temperatura2 = 32, DifTempera = 5 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Avila", Poblacion2 = "Santander", Temperatura1 = 32, Temperatura2 = 19, DifTempera = 13 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Girona", Poblacion2 = "Malaga", Temperatura1 = 35, Temperatura2 = 26, DifTempera = 9 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Albacete", Poblacion2 = "Merida", Temperatura1 = 18, Temperatura2 = 29, DifTempera = 11 });

            listaPobla.Add(new Poblaciones() { Poblacion1 = "Narbella", Poblacion2 = "Alacala de Henares", Temperatura1 = 15, Temperatura2 = 25, DifTempera = 10 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Almeria", Poblacion2 = "Orense", Temperatura1 = 12, Temperatura2 = 18, DifTempera = 6 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Huelva", Poblacion2 = "Melillá", Temperatura1 = 27, Temperatura2 = 32, DifTempera = 5 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Avila", Poblacion2 = "Ciudad Real", Temperatura1 = 32, Temperatura2 = 19, DifTempera = 13 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Cartagena", Poblacion2 = "Ceuta", Temperatura1 = 35, Temperatura2 = 26, DifTempera = 9 });
            listaPobla.Add(new Poblaciones() { Poblacion1 = "Jaén", Poblacion2 = "Teruel", Temperatura1 = 18, Temperatura2 = 29, DifTempera = 11 });

            ListaPoblaciones.ItemsSource = listaPobla;

        }

        private void ListaPoblaciones_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if(ListaPoblaciones.SelectedItem != null) 
            { 
                MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones).Poblacion1+" "+ (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C "+ (ListaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " + (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C");
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun elemento de la lista");
            }
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ListaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " + (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C " + (ListaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " + (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C");
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun elemento de la lista");
            }
        }

    }

    public class Poblaciones
    {
        public string Poblacion1 { get; set; }
        public int    Temperatura1 { get; set; }
        public string Poblacion2 { get; set; }
        public int Temperatura2 { get; set; }

        public int DifTempera { get; set; }

    }





}
