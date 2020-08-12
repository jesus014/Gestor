using GestorCyF.UI.Controles;
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

namespace GestorCyF.UI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtFecha.Text = DateTime.Now.ToShortDateString();
            txtHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void ClutchYFrenosPrincipal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VerVentas_Click(object sender, RoutedEventArgs e)
        {
            AbrirCatalogo("Ventas", new ControlVentas());
        }

        private void NuevaVenta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VerCompras_Click(object sender, RoutedEventArgs e)
        {
            AbrirCatalogo("Compras", new ControlCompras());
        }

        private void NuevaCompra_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VerProductos_Click(object sender, RoutedEventArgs e)
        {
            AbrirCatalogo("Productos", new ControlProductos());
        }

        private void NuevoProducto_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VerServicios_Click(object sender, RoutedEventArgs e)
        {
            AbrirCatalogo("Servicios", new ControlServicios());
        }

        private void NuevoServicio_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VerClientes_Click(object sender, RoutedEventArgs e)
        {
            AbrirCatalogo("Clientes", new ControlClientes());
        }

        private void NuevoCliente_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VerProveedores_Click(object sender, RoutedEventArgs e)
        {
            AbrirCatalogo("Proveesores", new ControlProveedores());
        }

        private void NuevoProveedor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void AbrirCatalogo(string titulo, Control control)
        {
            Contenedor principal = new Contenedor(control);
            principal.skpContenedor.Children.Clear();
            principal.Title.Content = titulo;
            principal.skpContenedor.Children.Add(control);
            Contenedor.Children.Clear();
            Contenedor.Children.Add(principal);
        }
    }
}
