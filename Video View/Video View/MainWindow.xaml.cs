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

namespace VideoView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void openfilemp4click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "";
            dlg.Filter = "Video Files (*.mp4)|*.mp4|Video Files (*.m4v)|*.m4v|Video Files (*.mkv)|*.mkv|Video Files (*.3g2)|*.3g2|Video Files (*.mpeg)|*.mpeg|All Files (*.*)|*.*";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                Uri videomp4 = new Uri(dlg.FileName, UriKind.RelativeOrAbsolute);
                video.Source = videomp4;
            }
        }
    }
}
