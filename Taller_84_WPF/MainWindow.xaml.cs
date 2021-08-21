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

namespace Taller_84_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Ciudades> ListaCiudades = new List<Ciudades>();

            ListaCiudades.Add(new Ciudades { NombreCiudad = "Madrid" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Barcelona" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Sevilla" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Valencia" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "La Coruña" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Vigo" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Bilbao" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Tenerife" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Murcia" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "San Sebastian" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Canarias" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Alicante" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Almeria" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Alaves" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Burgos" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Cadiz" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Cartagena" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Cordova" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Gijon" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Granada" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Malaga" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Betis" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Jerez" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Marbella" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Oviedo" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Pamplona" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Santander" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Tarragona" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Toledo" });
            ListaCiudades.Add(new Ciudades { NombreCiudad = "Zaragoza" });

            Municipios.ItemsSource = ListaCiudades;


        }

        private void Todas_Checked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = true;
            Barcelona.IsChecked = true;
            Sevilla.IsChecked = true;
            Valencia.IsChecked = true;
            LaCoruna.IsChecked = true;
            Vigo.IsChecked = true;
            Bilbao.IsChecked = true;
            Tenerife.IsChecked = true;
            Murcia.IsChecked = true;
            SanSebastian.IsChecked = true;
            Canarias.IsChecked = true;
            Alicante.IsChecked = true;
            Almeria.IsChecked = true;
            Alaves.IsChecked = true;
            Burgos.IsChecked = true;
            Cadiz.IsChecked = true;
            Cartagena.IsChecked = true;
            Cordova.IsChecked = true;
            Gijon.IsChecked = true;
            Granada.IsChecked = true;
            Malaga.IsChecked = true;
            Betis.IsChecked = true;
            Jerez.IsChecked = true;
            Marbella.IsChecked = true;
            Oviedo.IsChecked = true;
            Pamplona.IsChecked = true;
            Santander.IsChecked = true;
            Tarragona.IsChecked = true;
            Toledo.IsChecked = true;
            Zaragoza.IsChecked = true;
        }

        private void Todas_Unchecked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = false;
            Barcelona.IsChecked = false;
            Sevilla.IsChecked = false;
            Valencia.IsChecked = false;
            LaCoruna.IsChecked = false;
            Vigo.IsChecked = false;
            Bilbao.IsChecked = false;
            Tenerife.IsChecked = false;
            Murcia.IsChecked = false;
            SanSebastian.IsChecked = false;
            Canarias.IsChecked = false;
            Alicante.IsChecked = false;
            Almeria.IsChecked = false;
            Alaves.IsChecked = false;
            Burgos.IsChecked = false;
            Cadiz.IsChecked = false;
            Cartagena.IsChecked = false;
            Cordova.IsChecked = false;
            Gijon.IsChecked = false;
            Granada.IsChecked = false;
            Malaga.IsChecked = false;
            Betis.IsChecked = false;
            Jerez.IsChecked = false;
            Marbella.IsChecked = false;
            Oviedo.IsChecked = false;
            Pamplona.IsChecked = false;
            Santander.IsChecked = false;
            Tarragona.IsChecked = false;
            Toledo.IsChecked = false;
            Zaragoza.IsChecked = false;
        }

        private void Algunas_Checked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == true &&
                Barcelona.IsChecked == true &&
                Sevilla.IsChecked == true &&
                Valencia.IsChecked == true &&
                LaCoruna.IsChecked == true &&
                Vigo.IsChecked == true &&
                Bilbao.IsChecked == true &&
                Tenerife.IsChecked == true &&
                Murcia.IsChecked == true &&
                SanSebastian.IsChecked == true &&
                Canarias.IsChecked == true &&
                Alicante.IsChecked == true &&
                Almeria.IsChecked == true &&
                Alaves.IsChecked == true &&
                Burgos.IsChecked == true &&
                Cadiz.IsChecked == true &&
                Cartagena.IsChecked == true &&
                Cordova.IsChecked == true &&
                Gijon.IsChecked == true &&
                Granada.IsChecked == true &&
                Malaga.IsChecked == true &&
                Betis.IsChecked == true &&
                Jerez.IsChecked == true &&
                Marbella.IsChecked == true &&
                Oviedo.IsChecked == true &&
                Pamplona.IsChecked == true &&
                Santander.IsChecked == true &&
                Tarragona.IsChecked == true &&
                Toledo.IsChecked == true &&
                Zaragoza.IsChecked == true)
            {
                Todas.IsChecked = true;
            }
            else
            {
                Todas.IsChecked = null;

            }
        }

        private void Algunas_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == false &&
                Barcelona.IsChecked == false &&
                Sevilla.IsChecked == false &&
                Valencia.IsChecked == false &&
                LaCoruna.IsChecked == false &&
                Vigo.IsChecked == false &&
                Bilbao.IsChecked == false &&
                Tenerife.IsChecked == false &&
                Murcia.IsChecked == false &&
                SanSebastian.IsChecked == false &&
                Canarias.IsChecked == false &&
                Alicante.IsChecked == false &&
                Almeria.IsChecked == false &&
                Alaves.IsChecked == false &&
                Burgos.IsChecked == false &&
                Cadiz.IsChecked == false &&
                Cartagena.IsChecked == false &&
                Cordova.IsChecked == false &&
                Gijon.IsChecked == false &&
                Granada.IsChecked == false &&
                Malaga.IsChecked == false &&
                Betis.IsChecked == false &&
                Jerez.IsChecked == false &&
                Marbella.IsChecked == false &&
                Oviedo.IsChecked == false &&
                Pamplona.IsChecked == false &&
                Santander.IsChecked == false &&
                Tarragona.IsChecked == true &&
                Toledo.IsChecked == false &&
                Zaragoza.IsChecked == false)
            {
                Todas.IsChecked = false;
            }
            else
            {
                Todas.IsChecked = null;

            }
        }

        public class Ciudades
        {

            public string NombreCiudad { get; set; }
        }
    }
}
