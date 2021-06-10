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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string peremen1 = "";
        public string operation = "";
        public string peremen2 = "";
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement c in Grid.Children)
            {
                if (c is Button)
                {
                    ((Button)c).Click += Initialize;
                }
            }
        }
        private void Initialize(object sender, RoutedEventArgs e)
        {
            string s = (string)((Button)e.OriginalSource).Content;
            output.Text += s;
            int num;
            bool result = Int32.TryParse(s, out num);
            if (result == true)
            {
                if (operation == "")
                {
                    peremen1 += s;
                }
                else
                {
                    peremen2 += s;
                }
            }
            else
            {
                if (s == "=")
                {
                    Update_peremens();
                    output.Text += peremen2;
                    operation = "";
                }
                else if (s == "CLEAR")
                {
                    peremen1 = "";
                    peremen2 = "";
                    operation = "";
                    output.Text = "";
                }
                else
                {
                    if (peremen2 != "")
                    {
                        Update_peremens();
                        peremen1 = peremen2;
                        peremen2 = "";
                    }
                    operation = s;
                }
            }
        }
        private void Update_peremens()
        {
            try
            {
                double number1 = Double.Parse(peremen1);
                double number2 = Double.Parse(peremen2);
                switch (operation)
                {
                    case "+":
                        peremen2 = (number1 + number2).ToString();
                        break;
                    case "-":
                        peremen2 = (number1 - number2).ToString();
                        break;
                    case "*":
                        peremen2 = (number1 * number2).ToString();
                        break;
                    case "/":
                        try
                        {
                            peremen2 = (number1 / number2).ToString();
                        }
                        catch
                        {
                            MessageBox.Show("ZeroDivisionError : Cannot be divided by 0 !!!", "Erorr");
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Сalculation error !!!", "Erorr");
            }
        }
    }
}