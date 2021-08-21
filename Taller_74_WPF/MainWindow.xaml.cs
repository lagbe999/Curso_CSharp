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

namespace Taller_74_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Presionó Click en el Boton Anarillo ");
            Console.WriteLine("Presionó Click en el Boton Anarillo ");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Presionó Click en el Boton Azul ");
            Console.WriteLine("Presionó Click en el Boton Azul ");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Presionó Click en el Boton Rojo ");
            Console.WriteLine("Presionó Click en el Boton Rojo ");
        }
        /*
        private void Panel_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Presionó Click en el Panel");
            Console.WriteLine("Presionó Click en el Panel");
        }
        */
        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Presionó Click en el Panel");
        }
    }
}
