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

namespace Калькулятор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += "1";
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += "2";
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            tb_Text.Text += "3";
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
    }
}
