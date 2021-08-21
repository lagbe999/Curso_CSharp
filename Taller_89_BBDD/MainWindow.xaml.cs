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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Taller_89_BBDD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection MiConexionSql;
        public MainWindow()
        {
            InitializeComponent();

            string MiConexion = ConfigurationManager.ConnectionStrings["Taller_89_BBDD.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            MiConexionSql = new SqlConnection(MiConexion);

            MuestraClientes();

            MuestraTodosPedidos();
        }

        private void MuestraClientes()
        {
            try
            {
                string consulta = "SELECT * FROM CLIENTE";

                SqlDataAdapter miAdapClientes = new SqlDataAdapter(consulta, MiConexionSql);

                using (miAdapClientes)
                {
                    DataTable clientesTabla = new DataTable();

                    miAdapClientes.Fill(clientesTabla);

                    listaClientes.DisplayMemberPath = "nombre";

                    listaClientes.SelectedValuePath = "Id";

                    listaClientes.ItemsSource = clientesTabla.DefaultView;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        } 

        private void listaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MuestraPedidos();
        }

        private void MuestraPedidos()
        {
            try
            {

                string consulta = "SELECT * FROM PEDIDO P INNER JOIN CLIENTE C ON C.id=P.cCliente WHERE C.id = @ClienteId";

                SqlCommand SqlComando = new SqlCommand(consulta, MiConexionSql);

                SqlDataAdapter miAdapPedidos = new SqlDataAdapter(SqlComando);

                using (miAdapPedidos)
                {
                    SqlComando.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);

                    DataTable pedidosTabla = new DataTable();

                    miAdapPedidos.Fill(pedidosTabla);

                    pedidosCliente.DisplayMemberPath = "fechaPedido";

                    pedidosCliente.SelectedValuePath = "Id";

                    pedidosCliente.ItemsSource = pedidosTabla.DefaultView;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void MuestraTodosPedidos()
        {
            try
            {
                string consulta = "SELECT *, CONCAT(cCliente, ' ', fechaPedido, ' ', formaPago) as REGPEDIDO FROM PEDIDO";

                SqlDataAdapter MiAdapTodoPed = new SqlDataAdapter(consulta, MiConexionSql);

                using (MiAdapTodoPed)
                {

                    DataTable PedidosTablaTodo = new DataTable();

                    MiAdapTodoPed.Fill(PedidosTablaTodo);

                    todosPedidos.DisplayMemberPath = "REGPEDIDO";

                    todosPedidos.SelectedValuePath = "Id";

                    todosPedidos.ItemsSource = PedidosTablaTodo.DefaultView;

                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void Borrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "DELETE FROM PEDIDO WHERE ID=@PEDIDOID";

                SqlCommand MiSqlCommand = new SqlCommand(consulta, MiConexionSql);

                MiConexionSql.Open();

                MiSqlCommand.Parameters.AddWithValue("@PEDIDOID", todosPedidos.SelectedValue);

                MiSqlCommand.ExecuteNonQuery();

                MiConexionSql.Close();

                MuestraTodosPedidos();
            }catch(Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void NuevoCliente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "INSERT INTO CLIENTE (nombre, direccion, poblacion, telefono) VALUES ('" + txtNombreCli.Text + "','" + txtDireccion.Text + "','" + txtPoblacion.Text + "','" + txtTelefono.Text + "')";

                //MessageBox.Show(consulta);

                SqlCommand MiSqlCommand = new SqlCommand(consulta, MiConexionSql);

                MiConexionSql.Open();

                //MiSqlCommand.Parameters.AddWithValue("@CLIENTEID", listaClientes.SelectedValue);

                MiSqlCommand.ExecuteNonQuery();

                MiConexionSql.Close();

                MuestraClientes();

                txtNombreCli.Text = "";

                txtDireccion.Text = "";

                txtPoblacion.Text = "";

                txtTelefono.Text = "";

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }

        private void BorrarCliente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "DELETE FROM CLIENTE WHERE ID=@CLIENTEID";

                SqlCommand MiSqlCommand = new SqlCommand(consulta, MiConexionSql);

                MiConexionSql.Open();

                MiSqlCommand.Parameters.AddWithValue("@CLIENTEID", listaClientes.SelectedValue);

                MiSqlCommand.ExecuteNonQuery();

                MiConexionSql.Close();

                MuestraClientes();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }


        }

        private void listaClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MuestraPedidos();
        }

        private void ActualizaCliente_Click(object sender, RoutedEventArgs e)
        {
            ActualizaCiente ventanaActualiza = new ActualizaCiente();

            //Opcion 1: Muestra Ventana NO Modal y el ListBox de Clientes se Refresca en el evento: Window_Activate
            ventanaActualiza.Show();

            try
            {
                string consulta = "SELECT * FROM CLIENTE WHERE ID=@CLIENTEID";

                SqlCommand MiSqlComm = new SqlCommand(consulta, MiConexionSql);

                SqlDataAdapter miAdapClientes = new SqlDataAdapter(MiSqlComm);

                using (miAdapClientes)
                {
                    MiSqlComm.Parameters.AddWithValue("CLIENTEID", listaClientes.SelectedValue);

                    DataTable ClientesTabla = new DataTable();

                    miAdapClientes.Fill(ClientesTabla);

                    ventanaActualiza.actClienteID.Text= ClientesTabla.Rows[0]["id"].ToString();

                    ventanaActualiza.actNombreCli.Text = ClientesTabla.Rows[0]["nombre"].ToString();

                    ventanaActualiza.actDireccion.Text = ClientesTabla.Rows[0]["direccion"].ToString();

                    ventanaActualiza.actPoblacion.Text= ClientesTabla.Rows[0]["poblacion"].ToString();

                    ventanaActualiza.actTelefono.Text= ClientesTabla.Rows[0]["telefono"].ToString();


                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }


            //Opcion 2: Para Mostrar Ventana Modal y Rrefrescar ListBox de Clientes con Los Cambios
            //ventanaActualiza.ShowDialog();

            //MuestraClientes();


        }

        private void Window_Activated(object sender, EventArgs e)
        {
            MuestraClientes();
        }
    }
}
