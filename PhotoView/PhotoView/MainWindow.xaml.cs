using System;
using System.Collections.Generic;
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
using System.Drawing;
using System.Threading;
using System.IO;
using Microsoft.Win32;

namespace PhotoView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            
        public int id = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void leftclick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (id != 0)
                    id--;
                string[] arr = new string[255];
                int i = 0;
                foreach (string pyth in Directory.EnumerateFiles(URI.Text))
                {
                    FileInfo fileinfo = new FileInfo(pyth);
                    arr[i] = pyth;
                    i++;
                }
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(arr[id]);
                bitmap.EndInit();
                img.Source = bitmap;
            }
            catch
            {
                MessageBox.Show("It's home !!!","Error");
            }
        }
        private void rightclick(object sender, RoutedEventArgs e)
        {
            try
            { 
                if (id != 255)
                    id++;
                string[] arr = new string[255];
                int i = 0;
                foreach (string pyth in Directory.EnumerateFiles(URI.Text))
                {
                    FileInfo fileinfo = new FileInfo(pyth);
                    arr[i] = pyth;
                    i++;
                }
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(arr[id]);
                bitmap.EndInit();
                img.Source = bitmap;
            }
            catch
            {
                MessageBox.Show("No more files !!!", "ERROR");
            }
        }
        private void openfileclick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "";
            dlg.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                try
                {
                    string selectedFileName = dlg.FileName;
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(selectedFileName);
                    bitmap.EndInit();
                    img.Source = bitmap;
                }
                catch
                {
                }
            }
        }

        private void GO(object sender, RoutedEventArgs e)
        {
            try
            {
                string[] arr = new string[225];
                int i = 0;
                foreach (string pyth in Directory.EnumerateFiles(URI.Text))
                {
                    FileInfo fileinfo = new FileInfo(pyth);
                    arr[i] = pyth;
                    i++;
                }
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(arr[id]);
                bitmap.EndInit();
                img.Source = bitmap;
            }
            catch
            {
                MessageBox.Show("Incorrect pyth !!! ","ERROR");
            }
        }
    }
}