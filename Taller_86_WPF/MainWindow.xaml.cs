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

namespace Taller_86_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SemaforoVacio.Visibility = Visibility.Visible; // imagen visible;
            SemaforoRojo.Visibility = Visibility.Collapsed; // imagen oculta;
            SemaforoAmarillo.Visibility = Visibility.Collapsed; // imagen oculta;
            SemaforoVerde.Visibility = Visibility.Collapsed; // imagen oculta;

        }

        private void ColorRojo_Checked(object sender, RoutedEventArgs e)
        {
            SemaforoVacio.Visibility = Visibility.Collapsed; // imagen oculta;
            SemaforoRojo.Visibility = Visibility.Visible; // imagen visible;
            SemaforoAmarillo.Visibility = Visibility.Collapsed; // imagen oculta;
            SemaforoVerde.Visibility = Visibility.Collapsed; // imagen oculta;
        }

        private void ColorAmarillo_Checked(object sender, RoutedEventArgs e)
        {
            SemaforoVacio.Visibility = Visibility.Collapsed; // imagen oculta;
            SemaforoRojo.Visibility = Visibility.Collapsed; // imagen oculta;
            SemaforoAmarillo.Visibility = Visibility.Visible; // imagen visible;
            SemaforoVerde.Visibility = Visibility.Collapsed; // imagen oculta;
        }

        private void ColorVerde_Checked(object sender, RoutedEventArgs e)
        {
            SemaforoVacio.Visibility = Visibility.Collapsed; // imagen oculta;
            SemaforoRojo.Visibility = Visibility.Collapsed; // imagen oculta;
            SemaforoAmarillo.Visibility = Visibility.Collapsed; // imagen oculta;
            SemaforoVerde.Visibility = Visibility.Visible; // imagen visible;
        }
    }
}
