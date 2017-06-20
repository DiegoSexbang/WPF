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
    /// Lógica de interacción para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

       

        

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenProductos_Click(object sender, RoutedEventArgs e)
        {
            MainWindow formproductos = new MainWindow();
            formproductos.Owner = App.Current.MainWindow;
            formproductos.Show();
            
        }

        private void MenReproductor_Click(object sender, RoutedEventArgs e)
        {
            Reproductor formreproductor = new Reproductor();
            formreproductor.Owner = App.Current.MainWindow;
            formreproductor.Show();
        } private void MenListas_Click(object sender, RoutedEventArgs e)
        {
            Listas formlista = new Listas();
            formlista.Owner = App.Current.MainWindow;
            formlista.Show();

        }

        private void MenCanciones_Click(object sender, RoutedEventArgs e)
        {
            Canciones formcancion = new Canciones();
            formcancion.Owner = App.Current.MainWindow;
            formcancion.Show();
        }

        private void MenReproductorMusica_Click(object sender, RoutedEventArgs e)
        {
            RCanciones formrcancion = new RCanciones();
            formrcancion.Owner = App.Current.MainWindow;
            formrcancion.Show();
        }
    }
}
