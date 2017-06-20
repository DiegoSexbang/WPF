using Controladores;
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
    /// Lógica de interacción para Listas.xaml
    /// </summary>
    public partial class Listas : Window
    {
        CListas lala = new CListas();
        public Listas()
        {
            InitializeComponent();
            CargarCombo();

           /* String[] nomrbes = lala.GeneroNombre();

            for (int i = 0; i < nomrbes.Length; i++)
            {
                cmbGenero.Items.Add(nomrbes[i]);
            }
            cmbGenero.SelectedIndex = 0; */


        }

        private void btnGuardar(object sender, RoutedEventArgs e)
        {
           
            lala.Agregar(Convert.ToInt32(txtNum.Text), txtLista.Text, Convert.ToInt32(cmbGenero.SelectedValue));
        }

        private void btnEliminar(object sender, RoutedEventArgs e)
        {
           lala.Eliminar(Convert.ToInt32(txtNum.Text));

        }

        private void btnActualizar(object sender, RoutedEventArgs e)
        {
            lala.Actualizar(Convert.ToInt32(txtNum.Text), txtLista.Text);
        }

        private void btnListado(object sender, RoutedEventArgs e)
        {
            ListadoLista formlista = new ListadoLista();
            formlista.Owner = App.Current.MainWindow;
            formlista.Show();

        }

        private void btnSalir(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void CargarCombo() {

            SqlDataReader lis;
            ComboBoxItem item = new ComboBoxItem();
            lis = lala.RecuperarGenero();
            cmbGenero.ItemsSource = lis;
            cmbGenero.DisplayMemberPath = "NombreGenero";
            cmbGenero.SelectedValuePath = "id_genero";
        }
        
        }
    }

