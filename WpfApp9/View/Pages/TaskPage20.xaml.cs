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
    /// Логика взаимодействия для TaskPage20.xaml
    /// </summary>
    public partial class TaskPage20 : Page
    {
        public TaskPage20()
        {
            InitializeComponent();
        }

        private void BtnTasck1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Tby.Text) | string.IsNullOrEmpty(Tbt.Text) | string.IsNullOrEmpty(Tbl.Text))
            {
                MessageBox.Show($"ОШИБКА!!!",
                                "Задание №20",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);

                Tby.Text = string.Empty;
                Tbt.Text = string.Empty;
                Tbl.Text = string.Empty;

            }
            else
            {
                double y = Convert.ToDouble(Tby.Text), t = Convert.ToDouble(Tbt.Text), l = Convert.ToDouble(Tbl.Text);

                MessageBox.Show($" K ={(2 * Math.Pow(t, 2) + 3 * l + 7.2) / (Math.Log10(y) + Math.Exp(2 * l))}",
                                "Задание №20",
                                 MessageBoxButton.OK,
                                 MessageBoxImage.Information);


                Tby.Text = string.Empty;
                Tbt.Text = string.Empty;
                Tbl.Text = string.Empty;

            }
        }
    }
}
