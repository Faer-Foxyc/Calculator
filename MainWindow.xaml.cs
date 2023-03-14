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
            tb_Text.Text += _dataClass.GetNumber(1);
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.GetNumber(2);
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.GetNumber(3);
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.GetNumber(4);
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.GetNumber(5);
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.GetNumber(6);
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.GetNumber(7);
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.GetNumber(8);
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.GetNumber(9);
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.GetNumber(0);
        }

        private void btn_Division_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.Division;
        }

        private void btn_Plus_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.Plus;
        }

        private void btn_Multiplication_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.Multyplication;
        }

        private void Equally_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.Equally;
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.Point;
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += _dataClass.Minus;
        }

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Clear();
        }

        private void btn_Procent_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text = _dataClass.Procent;
        }

        private void btn_Root_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text = _dataClass.Root;
        }

        private void btn_BackSpace_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text = _dataClass._DeleteSumbol(tb_Text.Text);
        }
    }
}
