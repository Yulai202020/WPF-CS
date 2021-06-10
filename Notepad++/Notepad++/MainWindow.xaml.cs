// wpf c#
using System;
using System.Windows;
using System.IO;
namespace Notepad__
{
    public partial class Not : Window
    {
        public Not()
        {
            InitializeComponent();
        }
        private void openfileclick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "All Files | *.*";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string readText = File.ReadAllText(dlg.FileName);
                text.Text = readText;
            }
        }
        private void savefileclick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.Filter = "All Files | *.*";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                Console.WriteLine(filename);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(filename)))
                { outputFile.WriteLine(text.Text); }
            }
        }
    }
}