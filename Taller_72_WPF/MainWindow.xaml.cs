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

namespace Taller_72_WPF
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

            Button miButton = new Button();

            miButton.Width = 300;

            miButton.Height = 40;

            miButton.FontSize = 24;

            miButton.Background = Brushes.Gray;

            miButton.Foreground = Brushes.Beige;

            WrapPanel miWrap = new WrapPanel();

            TextBlock txt1 = new TextBlock();

            txt1.Text = "Presiona ";

            txt1.FontStyle = FontStyles.Italic;

            txt1.Foreground = Brushes.Gold;

            miWrap.Children.Add(txt1);

            TextBlock txt2 = new TextBlock();

            txt2.Text = "Click";

            txt2.FontStyle = FontStyles.Italic;

            txt2.Foreground = Brushes.Blue;

            miWrap.Children.Add(txt2);

            TextBlock txt3 = new TextBlock();

            txt3.Text = "Para Enviar";

            txt2.FontStyle = FontStyles.Italic;

            txt3.Foreground = Brushes.Crimson;

            miWrap.Children.Add(txt3);

            miButton.Content = miWrap;


            miGrid.Children.Add(miButton);





        }
    }
}
