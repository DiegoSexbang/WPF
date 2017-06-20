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
    /// Lógica de interacción para ListadoLista.xaml
    /// </summary>
    public partial class ListadoLista : Window
    {
        AccesoListas acc = new AccesoListas();
        public ListadoLista()
        {
            InitializeComponent();
            CargarGrilla();
        }
        public void CargarGrilla()
        {
            SqlDataReader dat;
            dat = acc.RecuperarLista();
            GrillaDatos.ItemsSource = dat;
        }

    }
}
