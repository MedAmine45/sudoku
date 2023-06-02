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

namespace simpleCalcultor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int first; 
        int second;

        char op; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender , RoutedEventArgs e)
        {
            Button btn = sender as Button;
            txtResult.Text +=btn.Content.ToString();
            second = Int32.Parse(txtResult.Text);
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(txtResult.Text);
            op = '/';
            txtResult.Clear();
        }

        private void MulButton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(txtResult.Text);
            op = '*';
            txtResult.Clear();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Clear();
        }

            private void SubButton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(txtResult.Text);
            op = '-';
            txtResult.Clear();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(txtResult.Text);
            op = '+';
            txtResult.Clear();
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            second = Int32.Parse(txtResult.Text);
            int result = 0; 
            if(op == '+')
            {
                result = first + second;
            }
            else if (op == '-')
            {
                result = first - second;
            }
            else if (op == '*')
            {
                result = first * second;
            } else if (op == '/')
            {
                result = first / second;
            }
            if (txtResult.Text == "0")
            {
                txtResult.Clear();
            }
            txtResult.Text = result.ToString();
            
        }

    }
}
