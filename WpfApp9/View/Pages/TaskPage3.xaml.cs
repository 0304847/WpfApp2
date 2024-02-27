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
    /// Логика взаимодействия для TaskPage3.xaml
    /// </summary>
    public partial class TaskPage3 : Page
    {
        public TaskPage3()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbk.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №3",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbk.Text = string.Empty;
            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), k = Convert.ToDouble(Tbk.Text);

                MessageBox.Show($" U ={(Math.Log10(k - y) + Math.Pow(y, 4)) / (Math.Exp(y) + 2.355 * Math.Pow(k, 2))}",
                                "Задание №3",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbk.Text = string.Empty;

            }

        }
    }
}
