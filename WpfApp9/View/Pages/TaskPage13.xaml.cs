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

namespace WpfApp9.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TaskPage13.xaml
    /// </summary>
    public partial class TaskPage13 : Page
    {
        public TaskPage13()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbh.Text) | string.IsNullOrEmpty(Tbk.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №13",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbh.Text = string.Empty;
                Tbk.Text = string.Empty;
            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), h = Convert.ToDouble(Tbh.Text), k = Convert.ToDouble(Tbk.Text);

                MessageBox.Show($" A ={(Math.Sin(2 * y + h) + Math.Pow(h, 2)) / (Math.Exp(k) + y)}",
                                "Задание №13",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbh.Text = string.Empty;
                Tbk.Text = string.Empty;

            }
        }
    }
}
