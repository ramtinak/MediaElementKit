using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mediaElement.CurrentStateChanged += MediaElement_CurrentStateChanged;
            mediaElement.PositionChanged += MediaElement_PositionChanged;
        }
        List<Uri> lists = new List<Uri>
        {
            new Uri("http://dl.songdl.xyz/sOng/Single_2/JenabKhan/JenabKhan_Ft.Mohammad.Bahrani&Amir.SoltanAhmadi-Oomadim.Russia.mp3"),
            new Uri("http://download.abarfiles.com/media/1397/03/19/Mohsen%20Ebrahimzadeh%20-%20Doneh%20Doneh.mp3"),
            new Uri("http://dl.myfaza2music.ir/faza/Mohsen%20Ebrahimzadeh%20-%20Hagh%20Dari.mp3"),
        };
        private void MediaElement_PositionChanged(MediaElementKit.MediaElementPro sender, TimeSpan position)
        {
            if (sender.NaturalDuration != null && sender.NaturalDuration.HasTimeSpan)
                Debug.WriteLine(position + "\t\t\t" + sender.NaturalDuration.TimeSpan);
            else
            Debug.WriteLine(position);
        }

        private void MediaElement_CurrentStateChanged(MediaElementKit.MediaElementPro sender, MediaElementKit.PlayerState state)
        {
            Debug.WriteLine(state);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Source = new Uri("http://dl.song95.ir/files/mp3/Mohsen_Ebrahimzadeh-Ma_Ba_Hamim-SONG95IR.mp3");
            mediaElement.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                mediaElement.Stop();
            }
            catch { }
            mediaElement.SetMediaItems(lists);
            mediaElement.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mediaElement.PlayNext();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mediaElement.PlayPrevious();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            mediaElement.PlayShuffle();

        }
    }
}
