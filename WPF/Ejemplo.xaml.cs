using Microsoft.Win32;
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

namespace WPF
{
    /// <summary>
    /// Lógica de interacción para Ejemplo.xaml
    /// </summary>
    public partial class Ejemplo : Window
    {
        String path;
        public Ejemplo()
        {
            InitializeComponent();
        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void mediaOpen(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ruta = new OpenFileDialog();
            lblCancion.Content = "";
            ruta.Filter = "Musica mp3(*.mp3)|*.mp3";
            if (ruta.ShowDialog() == true)
            {
                path = ruta.FileName;
                lblCancion.Content += path;
                myMedia.LoadedBehavior = MediaState.Manual;
                myMedia.Source = new Uri(path);
            }

        }
    }
}
