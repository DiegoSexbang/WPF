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
using Controladores;

namespace WPF
{
    /// <summary>
    /// Lógica de interacción para RCanciones.xaml
    /// </summary>
    public partial class RCanciones : Window
    {
        CCanciones cc = new CCanciones();
        CListas cl = new CListas();
        string path;
        List<String> RutaArchivo = new List<String>();
        public RCanciones()
        {
            InitializeComponent();
            myMedia.Volume = 100;
            CargarCombo();
            myMedia.Play();

        }
        void mediaPlay(Object sender, EventArgs e)
        {
            myMedia.Play();
        }

        void mediaPause(Object sender, EventArgs e)
        {
            myMedia.Pause();
        }

        void mediaMute(Object sender, EventArgs e)
        {
            if (myMedia.Volume == 100)
            {
                myMedia.Volume = 0;
                muteButt.Content = "Listen";
            }
            else
            {
                myMedia.Volume = 100;
                muteButt.Content = "Mute";
            }
        }
        private void SeekToMediaPosition(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            int SliderValue = (int)timelineSlider.Value;
            
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            myMedia.Position = ts;


        }

       
        

        private void mediaPlay(object sender, RoutedEventArgs e)
        {
            myMedia.Play();
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lbCancion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (lbCancion.SelectedIndex >= 0)
            {
                string path = RutaArchivo[lbCancion.SelectedIndex];
                myMedia.Source = new Uri(path);
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
            myMedia.LoadedBehavior = MediaState.Manual;

        }

        private void cmbLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List();
            
        }
        public void List()
        {
            SqlDataReader lis;
            ListBoxItem item = new ListBoxItem();
            int variable = 0;
            variable = Convert.ToInt32(cmbLista.SelectedValue);
            lis = cc.RecuperarTabla2(variable);
            RecuperarRuta(variable);
            lbCancion.ItemsSource = lis;
            lbCancion.DisplayMemberPath = "NombreCancion";

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
       

        private void myMedia_MediaOpened_1(object sender, RoutedEventArgs e)
        {
            timelineSlider.Maximum = myMedia.NaturalDuration.TimeSpan.TotalMilliseconds;
        }
    }

}
