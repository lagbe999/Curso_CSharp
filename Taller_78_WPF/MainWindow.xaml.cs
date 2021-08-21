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

namespace Taller_78_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {


        public int miProperty
        {
            get { return (int)GetValue(miDependencyProperty); }

            set { SetValue(miDependencyProperty, value); }

        }

        public static readonly DependencyProperty miDependencyProperty = DependencyProperty.Register("miProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
