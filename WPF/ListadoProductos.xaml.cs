using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Controladores;
using System.Data;
using System.Data.SqlClient;

namespace WPF
{
    /// <summary>
    /// Lógica de interacción para ListadoProducots.xaml
    /// </summary>
    public partial class ListadoProductos : Window
    {
        private Controladores.CProducto datoproductos = new Controladores.CProducto();
        private SqlDataReader datos;

        public ListadoProductos()
        {
            InitializeComponent();
            Limpiar_Formulario();
        }
        

        
        public void Cargar_Grilla(SqlDataReader datos)
        {
            GrillaProductos.ItemsSource = datos;
           
        }

        public void Limpiar_Formulario()
        {
            txtCodProducto.Text = "";
            txtNombreProducto.Text = "";
            datos = datoproductos.RecuperarTabla();
            Cargar_Grilla(datos);
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if((txtCodProducto.Text=="") && (txtNombreProducto.Text!=""))
                datos=datoproductos.BuscarporNombre(txtNombreProducto.Text);
            if((txtCodProducto.Text!="") && (txtNombreProducto.Text==""))
                datos=datoproductos.BuscarporCodigo(Convert.ToInt32(txtCodProducto.Text));
            if((txtCodProducto.Text=="") && (txtNombreProducto.Text==""))
                datos=datoproductos.RecuperarTabla();
            Cargar_Grilla(datos);

        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar_Formulario();

        }

        private void txtCodProducto_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtCodProducto.Text != "")
                datos = datoproductos.BuscarporCodigo(Convert.ToInt32(txtCodProducto.Text));
            else
                datos = datoproductos.RecuperarTabla();
            Cargar_Grilla(datos);
        }

        private void txtNombreProducto_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNombreProducto.Text != "")
                datos = datoproductos.BuscarporNombre(txtNombreProducto.Text);
            else
                datos = datoproductos.RecuperarTabla();
            Cargar_Grilla(datos);
        }

        private void GrillaProductos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           
            //CProducto dato = new CProducto(); 
            //CProducto dato= GrillaProductos.SelectedItem as CProducto;
            int x= ((CProducto)GrillaProductos.Items[0]).CodProducto;
            //CProducto dato = (CProducto)GrillaProductos.SelectedItem;
            //MessageBox.Show(Convert.ToString(dato.CodProducto));
    

         }

       
    }
}
