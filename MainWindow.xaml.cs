using System.Windows;
using Калькулятор.Data;

namespace Калькулятор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClass _dataClass = new DataClass();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.NumbOne;
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.NumbTwo;
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.NumbThree;
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += "4";
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += "5";
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += "6";
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += "7";
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += "8";
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += "9";
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += "0";
        }

        private void btn_Division_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += "/";
        }

        private void btn_Plus_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += "+";
        }

        private void btn_Multiplication_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += "*";
        }

        private void Equally_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += "=";
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += ".";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += "-";
        }
    }
}
