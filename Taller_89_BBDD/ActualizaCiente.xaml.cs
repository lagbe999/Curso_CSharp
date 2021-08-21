using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace Taller_89_BBDD
{
    /// <summary>
    /// Lógica de interacción para ActualizaCiente.xaml
    /// </summary>
    public partial class ActualizaCiente : Window
    {
        SqlConnection MiConexionSql;

        public ActualizaCiente()
        {
            InitializeComponent();

            string MiConexion = ConfigurationManager.ConnectionStrings["Taller_89_BBDD.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            MiConexionSql = new SqlConnection(MiConexion);

        }

        private void GrabarCliente_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                string consulta = "UPDATE CLIENTE SET nombre='" + actNombreCli.Text + "', direccion='" + actDireccion.Text + "', poblacion='" + actPoblacion.Text + "', telefono='" + actTelefono.Text + "' WHERE ID=" + int.Parse(actClienteID.Text);

                //MessageBox.Show(consulta);

                SqlCommand MiSqlCommand = new SqlCommand(consulta, MiConexionSql);

                MiConexionSql.Open();

                MiSqlCommand.ExecuteNonQuery();

                MiConexionSql.Close();

                this.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }
    }
}
