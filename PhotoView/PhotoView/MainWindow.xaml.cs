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

namespace PhotoView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public byte a = 0;
        public string pyth = String.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void openfolderclick(object sender, RoutedEventArgs e)
        {
        }
        private void leftclick(object sender, RoutedEventArgs e)
        {
            a--;
            int a1 = 21;
            string filename11 = "";
            DirectoryInfo dir = new DirectoryInfo(@"C:\popa\");

            foreach (FileInfo files in dir.GetFiles())
            {
                filename11 = files.Name;
                a1--;
                if (a == a1)
                {
                    break;
                }
            }
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(filename11);
            bitmap.EndInit();
            img.Source = bitmap;
        }
        private void rightclick(object sender, RoutedEventArgs e)
        {
            a++;
            int a1 = 0;
            string filename = "";
            DirectoryInfo dir = new DirectoryInfo(@"C:\popa\");

            foreach (FileInfo files in dir.GetFiles())
            {
                filename = files.Name;
                a1++;
                if (a == a1)
                {
                    break;
                }
            }
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(filename);
            bitmap.EndInit();
            img.Source = bitmap;
        }
        private void openfileclick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] arr = new string[255]; 
            foreach (string pyth in Directory.EnumerateFiles(URI.Text))
            {
                //check file extension
                if (pyth.IndexOf(pyth,-4,-1) == ".png") {}
            }
        }
    }
}