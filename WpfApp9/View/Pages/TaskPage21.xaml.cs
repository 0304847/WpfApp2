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
    /// Логика взаимодействия для TaskPage21.xaml
    /// </summary>
    public partial class TaskPage21 : Page
    {
        public TaskPage21()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbk.Text) | string.IsNullOrEmpty(Tbp.Text) | string.IsNullOrEmpty(Tbx.Text) | string.IsNullOrEmpty(Tbd.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №21",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tbk.Text = string.Empty;
                Tbp.Text = string.Empty;
                Tbx.Text = string.Empty;
                Tbd.Text = string.Empty;

            }
            else
            {
                double k = Convert.ToDouble(Tbk.Text), p = Convert.ToDouble(Tbp.Text), x = Convert.ToDouble(Tbx.Text), d = Convert.ToDouble(Tbd.Text);

                MessageBox.Show($" Q ={(Math.Sqrt(k * 2.6 * p * Math.Sin(k))) / (x - Math.Pow(d, 3))}",
                                "Задание №21",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tbk.Text = string.Empty;
                Tbp.Text = string.Empty;
                Tbx.Text = string.Empty;
                Tbd.Text = string.Empty;

            }
        }
    }
}
