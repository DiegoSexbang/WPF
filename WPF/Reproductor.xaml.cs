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

namespace WPF
{
    /// <summary>
    /// Lógica de interacción para Reproductor.xaml
    /// </summary>
    public partial class Reproductor : Window
    {
        string path;
        public Reproductor()
        {
            InitializeComponent();
            myMedia.Volume = 100;
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

        private void mediaOpen(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ruta = new OpenFileDialog();
            lblCancion.Content = "";
            ruta.Filter = "Musica mp3(*.mp3)|*.mp3|Videos(*.mpeg,*.mpg,*.avi)|*.mpeg;*.mpg;*.avi|Videos WMA(*.wmv)|*.wmv";
            if (ruta.ShowDialog() == true)
            {
                path = ruta.FileName;
                lblCancion.Content += path;
                myMedia.LoadedBehavior =MediaState.Manual;
                myMedia.Source = new Uri(path);
            }


        }

        private void SeekToMediaPosition(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
       
         int SliderValue = (int)timelineSlider.Value;

          // Overloaded constructor takes the arguments days, hours, minutes, seconds, miniseconds.
          // Create a TimeSpan with miliseconds equal to the slider value.
          TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
          myMedia.Position = ts;
    

        }

        private void myMedia_MediaOpened(object sender, RoutedEventArgs e)
        {
           timelineSlider.Maximum = myMedia.NaturalDuration.TimeSpan.TotalMilliseconds;
   
        }

        private void mediaPlay(object sender, RoutedEventArgs e)
        {
            myMedia.Play();
        }
    }
}

