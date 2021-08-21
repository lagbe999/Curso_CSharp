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

namespace Taller_WPF_01
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid miGrid = new Grid();
            this.Content = miGrid;
            Button miBoton = new Button();
            miBoton.Width = 180;
            miBoton.Height = 60;
            WrapPanel miWrap =new WrapPanel();
            TextBlock txt1 = new TextBlock();
            txt1.Text = "Amarillo ";

            miWrap.Children.Add(txt1);

            TextBlock txt2 = new TextBlock();
            txt2.Text = "Azul ";
            miWrap.Children.Add(txt2);

            TextBlock txt3 = new TextBlock();
            txt3.Text = "Rojo";
            miWrap.Children.Add(txt3);

            miBoton.Content = miWrap;
            miGrid.Children.Add(miBoton);
        }
    }
}
