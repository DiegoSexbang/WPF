using Controladores;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace WPF
{
    /// <summary>
    /// Lógica de interacción para ListadoCanciones.xaml
    /// </summary>
    public partial class ListadoCanciones : Window
    {
        AccesoCanciones acc = new AccesoCanciones();
        SqlDataReader datos;
        CCanciones cc = new CCanciones();
        public ListadoCanciones()
        {
            InitializeComponent();
            CargarGrilla(datos);
        }
        public void CargarGrilla(SqlDataReader datos)
        {
            
            GrillaDatos.ItemsSource = datos;
        }

        

        private void txtCancion_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtCancion.Text != "")
            {
                datos = cc.BuscarCancion(txtCancion.Text);
            }
            else
                datos = cc.RecuperarTabla();
            CargarGrilla(datos);

        }

        private void txtArtista_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtArtista.Text != "")
            {
                datos = cc.BuscarArtista(txtArtista.Text);
            }
            else
                datos = cc.RecuperarTabla();
            CargarGrilla(datos);
        }
    }
}
