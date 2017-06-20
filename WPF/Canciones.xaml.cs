using Controladores;
using Modelo;
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
using Microsoft.Win32;
using System.Data.SqlClient;

namespace WPF
{
    /// <summary>
    /// Lógica de interacción para Canciones.xaml
    /// </summary>
    public partial class Canciones : Window
    {
        
        CCanciones cc = new CCanciones();
        CListas cl = new CListas();
        List<String> RutaArchivo = new List<String>();
        List<String> Cancion = new List<String>();
        int variable = 0;
        public Canciones()
        {
            InitializeComponent();
            CargarCombo();
           /* List<int> NumeroLista = cl.RecuperarLista();

            for (int i = 0; i < NumeroLista.Count; i++)
            {
                cmbLista.Items.Add(NumeroLista[i]);
            }
            cmbLista.SelectedIndex = -1; */

        }

        private void btnGuardar(object sender, RoutedEventArgs e)
        {
            cc.Agregar(Convert.ToInt32(cmbLista.SelectedValue), txtCancion.Text, txtArchivo.Text, txtArtista.Text);
            Listboxx();
            LimpiarFormulario();
        }

        private void btnActualizar(object sender, RoutedEventArgs e)
        {
            cc.Actualizar(txtCancion.Text, txtArtista.Text);
            Listboxx();
            LimpiarFormulario();
        }

        private void btnEliminar(object sender, RoutedEventArgs e)
        {
            
            variable = Convert.ToInt32(lbCanciones.SelectedValue);
            cc.Eliminar(variable);
            Listboxx();
            LimpiarFormulario();

        }

        private void btnListado(object sender, RoutedEventArgs e)
        {
            ListadoCanciones formlistacancion = new ListadoCanciones();
            formlistacancion.Owner = App.Current.MainWindow;
            formlistacancion.Show();
        }

        private void btnSalir(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void btnAgregar(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ruta = new OpenFileDialog();
           
            ruta.Filter = "Musica mp3(*.mp3)|*.mp3";
            if (ruta.ShowDialog() == true)
            {
                txtCancion.Text = ruta.SafeFileName;
                txtArchivo.Text = ruta.FileName;
            }

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Listboxx();





        }

        private void lbCanciones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbCanciones.SelectedIndex >= 0)
            {
                txtArchivo.Text = RutaArchivo[lbCanciones.SelectedIndex];
                txtCancion.Text = Cancion[lbCanciones.SelectedIndex];
            }
        }
        public void CargarCombo()
        {

            SqlDataReader lis;
            ComboBoxItem item = new ComboBoxItem();
            lis = cl.RecuperarLiista();
            cmbLista.ItemsSource = lis;
            cmbLista.DisplayMemberPath = "NombreLista";
            cmbLista.SelectedValuePath = "NumeroLista";
        }
        public void LimpiarFormulario() {
            txtArchivo.Text = "";
            txtArtista.Text = "";
            txtCancion.Text = "";

        }

        public void Listboxx()
        {

            SqlDataReader lis;
            ListBoxItem item = new ListBoxItem();

            

            variable = Convert.ToInt32(cmbLista.SelectedValue);
            lis = cc.RecuperarTabla2(variable);
            RecuperarRuta(variable);
            RecuperarCancion(variable);
            lbCanciones.ItemsSource = lis;
            lbCanciones.DisplayMemberPath = "NombreCancion";
            lbCanciones.SelectedValuePath = "id_cancion";
            

        }
        public void RecuperarRuta(int idlista)
        {

            CCanciones ca = new CCanciones();
            SqlDataReader resultado = ca.RecuperarTabla2(idlista);

            RutaArchivo.Clear();//Se limpian 

            if (idlista >= 0)
            {
                while (resultado.Read())
                {
                    RutaArchivo.Add(resultado["RUTAARCHIVO"].ToString());

                }
            }

        }

        public void RecuperarCancion(int idlista)
        {

            CCanciones ca = new CCanciones();
            SqlDataReader resultado = ca.RecuperarTabla2(idlista);

            Cancion.Clear();//Se limpian 

            if (idlista >= 0)
            {
                while (resultado.Read())
                {
                    Cancion.Add(resultado["NOMBRECANCION"].ToString());

                }
            }

        }
    }
}
